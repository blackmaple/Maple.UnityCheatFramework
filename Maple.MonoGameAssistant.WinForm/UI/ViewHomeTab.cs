using DevExpress.XtraEditors;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.UILogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maple.MonoGameAssistant.WinForm
{
    public partial class ViewHomeTab : DevExpress.XtraEditors.XtraForm
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public required ViewMainForm ViewMainForm { set; get; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public required UIService UIService { set; get; }
        GameContextFactory GameContextFactory => UIService.GameContextFactory;
        UIBindingList<UIProcessInfo> BindListProcess { get; } = [];

        static ViewHomeTab()
        {
            XtraMessageBox.AllowHtmlText = true;
        }

        public ViewHomeTab(ViewMainForm viewMainForm, UIService uIService) : this()
        {
            this.MdiParent = viewMainForm;
            this.ViewMainForm = viewMainForm;
            this.UIService = uIService;

        }

        public ViewHomeTab()
        {
            InitializeComponent();
            //     this.gvProcess.RowCountChanged += (sender, e) => this.gvProcess.BestFitColumns();
            this.gcProcess.DataSource = this.BindListProcess;
            this.gvProcess.SetGridViewRowNumber();
            this.gvProcess.RowCellClick += async (sender, e) => await OpenViewGameTab(sender, e);

        }


        private async ValueTask OpenViewGameTab(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (false == UIHelper.TryGetDoubleClickedRowCellObject<UIProcessInfo>(sender, e, default, out var processInfo))
            {
                return;
            }
            if (DialogResult.OK != XtraMessageBox.Show(this, $"OpenGame <color=red>{processInfo.DisplayName}</color>", "OpenGame", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                return;
            }


            if (false == System.Diagnostics.Process.GetProcessesByName(processInfo.ProcessName).Any(p => p.Id == processInfo.ProcessId))
            {
                await this.ViewMainForm.ShowMsg($"{processInfo.DisplayName} Has Already Exited");
                this.BtnLoadProcess.PerformClick();
                return;
            }
            await this.ViewMainForm.AddGameTab(processInfo.DisplayName);
        }

        private async void BtnCreateHttp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await OpenViewGameTab2();
        }
        private async ValueTask OpenViewGameTab2()
        {
            var args = XtraInputBox.Show(this, "", "http url", string.Empty);
            if (string.IsNullOrEmpty(args))
            {
                return;
            }
            await this.ViewMainForm.AddGameTab(args, nameof(NormalHttpClientFactory));
        }


        private async void ViewHomeTab_Load(object sender, EventArgs e)
        {
            await Task.Delay(500);
            BtnLoadProcess.PerformClick();
        }

        private async void BtnLoadProcess_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (this.ShowSplashScreen())
            {
                var datas = await UIProcessInfo.GetUIProcessInfosAsync();
                this.BindListProcess.ReplaceRange(datas);
            }
        }

        private async void BtnShowJsonCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.TrySaveFileDialog(out var selectedFile))
            {
                await using var fileStream = File.OpenRead(selectedFile);
                var classdto = await System.Text.Json.JsonSerializer.DeserializeAsync(fileStream, MonoJsonContext.Default.MonoClassDetailDTO);
                if (classdto is null)
                {
                    return;
                }
                GameClassInfo gameClassInfo = new()
                {
                    RawClassInfo = classdto.ClassInfoDTO,
                    ParentClassInfos = classdto.ParentClassInfos?.Select(p => new GameParentClassInfo { RawClassInfo = p }).ToArray() ?? [],
                    InterfaceInfos = classdto.InterfaceInfos?.Select(p => new GameInterfaceInfo { RawInterfaceInfo = p }).ToArray() ?? [],
                    MethodInfos = classdto.MethodInfos?.Select(p => new GameMethodInfo { RawMethodInfo = p }).ToArray() ?? [],
                    FieldInfos = classdto.FieldInfos?.Select(p => new GameFieldInfo { RawFieldInfo = p }).ToArray() ?? [],

                };
                await OpenPageCodeViewAsync(gameClassInfo);
            }
        }

        private async Task OpenPageCodeViewAsync(GameClassInfo gameClassInfo)
        {
            string codeView;

            var dialogResult = XtraMessageBox.Show(this, "Selected V2", "Selected V2?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                codeView = await gameClassInfo.ShowCodeV2Async("Maple.Game");
            }
            else
            {
                codeView = await gameClassInfo.ShowCodeAsync("Maple.Game");

            }



            using var pageCodeEditor = this.UIService.GetForm<PageCodeEditor>();
            pageCodeEditor.SetCodeView(codeView);
            var args = new XtraDialogArgs
            {
                Owner = default,
                Caption = gameClassInfo.RawClassInfo.FullName,
                Buttons = [System.Windows.Forms.DialogResult.OK, System.Windows.Forms.DialogResult.Yes/*, System.Windows.Forms.DialogResult.Continue*/],
                Content = pageCodeEditor,
                ContentPadding = new System.Windows.Forms.Padding(10)
            };
            args.Showing += (s, e) =>
            {
                var button = e.Buttons[System.Windows.Forms.DialogResult.Yes];
                button.Text = "Copy";
                button.Click += (bs, be) =>
                {
                    System.Windows.Clipboard.Clear();
                    System.Windows.Clipboard.SetText(codeView);
                };

                //var btnWrite = e.Buttons[System.Windows.Forms.DialogResult.Continue];
                //btnWrite.Text = "Write";
                //btnWrite.Click += async (bs, be) =>
                //{
                //    await WriteClassFileV2Async(gameClassInfo.RawClassInfo.FullName ?? $"{DateTime.Now:yyyyMMddHHmmssffff}", codeView);
                //};

            };
            XtraDialog.Show(args);


        }


    }
}