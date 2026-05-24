using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataUnity.UnityMetadata;
using System.Numerics;

namespace Maple.MonoGameAssistant.MetadataUnity
{
    /// <summary>
    /// class ["UnityEngine.InputLegacyModule.dll"."UnityEngine"."Input"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_Input>, Ptr_Input>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("UnityEngine.InputLegacyModule.dll", "UnityEngine", "Input", "UnityEngine.Input")]
    public partial class Input
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_Input(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_Input(System.IntPtr ptr) => new Ptr_Input(ptr);
            public static implicit operator System.IntPtr(Ptr_Input ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_Input ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["UnityEngine.InputLegacyModule.dll"."UnityEngine"."Input"]
        /// </summary>
        partial struct Ptr_Input
        {
            /// <summary>
            /// 0x0 UnityEngine.LocationService locationServiceInstance
            /// class ["UnityEngine.InputLegacyModule.dll"."UnityEngine"."LocationService"]
            /// </summary>
            /// <returns>class UnityEngine.LocationService</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("locationServiceInstance", "UnityEngine.LocationService")]
            public static partial nint LOCATION_SERVICE_INSTANCE { get; set; } 
*/

            /// <summary>
            /// 0x8 UnityEngine.Compass compassInstance
            /// class ["UnityEngine.InputLegacyModule.dll"."UnityEngine"."Compass"]
            /// </summary>
            /// <returns>class UnityEngine.Compass</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("compassInstance", "UnityEngine.Compass")]
            public static partial nint COMPASS_INSTANCE { get; set; } 
*/

            /// <summary>
            /// 0x10 UnityEngine.Gyroscope s_MainGyro
            /// class ["UnityEngine.InputLegacyModule.dll"."UnityEngine"."Gyroscope"]
            /// </summary>
            /// <returns>class UnityEngine.Gyroscope</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("s_MainGyro", "UnityEngine.Gyroscope")]
            public static partial nint S_MAIN_GYRO { get; set; } 
*/
        }

        /// <summary>
        /// class ["UnityEngine.InputLegacyModule.dll"."UnityEngine"."Input"]
        /// </summary>
        partial struct Ptr_Input
        {
            /// <summary>
            /// static  System.Boolean CheckDisabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckDisabled", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial System.Boolean CHECK_DISABLED(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 get_acceleration()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_acceleration", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial UnityEngine.Vector3 GET_ACCELERATION(); 
*/
            /// <summary>
            /// static  System.Void get_acceleration_Injected(UnityEngine.Vector3& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.Vector3&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_acceleration_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3&", 0)]
           public static partial void GET_ACCELERATION_INJECTED(UnityEngine.Vector3 &ret); 
*/
            /// <summary>
            /// static  System.Int32 get_accelerationEventCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_accelerationEventCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial System.Int32 GET_ACCELERATION_EVENT_COUNT(); 
*/
            /// <summary>
            /// static  UnityEngine.AccelerationEvent[] get_accelerationEvents()
            /// </summary>
            /// <returns>class UnityEngine.AccelerationEvent[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_accelerationEvents", "UnityEngine.AccelerationEvent[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial nint GET_ACCELERATION_EVENTS(); 
*/
            /// <summary>
            /// static  System.Boolean get_anyKey()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_anyKey", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial System.Boolean GET_ANY_KEY(); 
*/
            /// <summary>
            /// static  System.Boolean get_anyKeyDown()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_anyKeyDown", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial System.Boolean GET_ANY_KEY_DOWN(); 
*/
            /// <summary>
            /// static  System.Boolean get_backButtonLeavesApp()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_backButtonLeavesApp", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial System.Boolean GET_BACK_BUTTON_LEAVES_APP(); 
*/
            /// <summary>
            /// static  UnityEngine.Compass get_compass()
            /// </summary>
            /// <returns>class UnityEngine.Compass</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_compass", "UnityEngine.Compass", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial nint GET_COMPASS(); 
*/
            /// <summary>
            /// static  System.Boolean get_compensateSensors()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_compensateSensors", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial System.Boolean GET_COMPENSATE_SENSORS(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 get_compositionCursorPos()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_compositionCursorPos", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial UnityEngine.Vector2 GET_COMPOSITION_CURSOR_POS(); 
*/
            /// <summary>
            /// static  System.Void get_compositionCursorPos_Injected(UnityEngine.Vector2& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.Vector2&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_compositionCursorPos_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2&", 0)]
           public static partial void GET_COMPOSITION_CURSOR_POS_INJECTED(UnityEngine.Vector2 &ret); 
*/
            /// <summary>
            /// static  System.String get_compositionString()
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_compositionString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial nint GET_COMPOSITION_STRING(); 
*/
            /// <summary>
            /// static  UnityEngine.DeviceOrientation get_deviceOrientation()
            /// </summary>
            /// <returns>enum UnityEngine.DeviceOrientation</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_deviceOrientation", "UnityEngine.DeviceOrientation", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial UnityEngine.DeviceOrientation GET_DEVICE_ORIENTATION(); 
*/
            /// <summary>
            /// static  System.Boolean get_eatKeyPressOnTextFieldFocus()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_eatKeyPressOnTextFieldFocus", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial System.Boolean GET_EAT_KEY_PRESS_ON_TEXT_FIELD_FOCUS(); 
*/
            /// <summary>
            /// static  UnityEngine.Gyroscope get_gyro()
            /// </summary>
            /// <returns>class UnityEngine.Gyroscope</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_gyro", "UnityEngine.Gyroscope", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial nint GET_GYRO(); 
*/
            /// <summary>
            /// static  UnityEngine.IMECompositionMode get_imeCompositionMode()
            /// </summary>
            /// <returns>enum UnityEngine.IMECompositionMode</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_imeCompositionMode", "UnityEngine.IMECompositionMode", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial UnityEngine.IMECompositionMode GET_IME_COMPOSITION_MODE(); 
*/
            /// <summary>
            /// static  System.Boolean get_imeIsSelected()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_imeIsSelected", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial System.Boolean GET_IME_IS_SELECTED(); 
*/
            /// <summary>
            /// static  System.String get_inputString()
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_inputString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial nint GET_INPUT_STRING(); 
*/
            /// <summary>
            /// static  System.Boolean get_isGyroAvailable()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_isGyroAvailable", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial System.Boolean GET_IS_GYRO_AVAILABLE(); 
*/
            /// <summary>
            /// static  UnityEngine.LocationService get_location()
            /// </summary>
            /// <returns>class UnityEngine.LocationService</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_location", "UnityEngine.LocationService", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial nint GET_LOCATION(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 get_mousePosition()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_mousePosition", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial UnityEngine.Vector3 GET_MOUSE_POSITION(); 
*/
            /// <summary>
            /// static  System.Void get_mousePosition_Injected(UnityEngine.Vector3& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.Vector3&</param>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_mousePosition_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3&", 0)]
            public static partial void GET_MOUSE_POSITION_INJECTED(MapleOut<Vector3.Ref_Vector3>  ret);

            /// <summary>
            /// static  System.Boolean get_mousePresent()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_mousePresent", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial System.Boolean GET_MOUSE_PRESENT(); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 get_mouseScrollDelta()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_mouseScrollDelta", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial UnityEngine.Vector2 GET_MOUSE_SCROLL_DELTA(); 
*/
            /// <summary>
            /// static  System.Void get_mouseScrollDelta_Injected(UnityEngine.Vector2& ret)
            /// </summary>
            /// <param name = "ret">struct UnityEngine.Vector2&</param>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_mouseScrollDelta_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2&", 0)]
            public static partial void GET_MOUSE_SCROLL_DELTA_INJECTED(MapleOut<Vector2.Ref_Vector2> ret);

            /// <summary>
            /// static  System.Boolean get_multiTouchEnabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_multiTouchEnabled", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial System.Boolean GET_MULTI_TOUCH_ENABLED(); 
*/
            /// <summary>
            /// static  System.Boolean get_simulateMouseWithTouches()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_simulateMouseWithTouches", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial System.Boolean GET_SIMULATE_MOUSE_WITH_TOUCHES(); 
*/
            /// <summary>
            /// static  System.Boolean get_stylusTouchSupported()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_stylusTouchSupported", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial System.Boolean GET_STYLUS_TOUCH_SUPPORTED(); 
*/
            /// <summary>
            /// static  System.Int32 get_touchCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_touchCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial System.Int32 GET_TOUCH_COUNT(); 
*/
            /// <summary>
            /// static  UnityEngine.Touch[] get_touches()
            /// </summary>
            /// <returns>class UnityEngine.Touch[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_touches", "UnityEngine.Touch[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial nint GET_TOUCHES(); 
*/
            /// <summary>
            /// static  System.Boolean get_touchPressureSupported()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_touchPressureSupported", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial System.Boolean GET_TOUCH_PRESSURE_SUPPORTED(); 
*/
            /// <summary>
            /// static  System.Boolean get_touchSupported()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_touchSupported", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial System.Boolean GET_TOUCH_SUPPORTED(); 
*/
            /// <summary>
            /// static  UnityEngine.AccelerationEvent GetAccelerationEvent(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct UnityEngine.AccelerationEvent</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAccelerationEvent", "UnityEngine.AccelerationEvent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public static partial UnityEngine.AccelerationEvent GET_ACCELERATION_EVENT(System.Int32 index); 
*/
            /// <summary>
            /// static  System.Void GetAccelerationEvent_Injected(System.Int32 index, UnityEngine.AccelerationEvent& ret)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "ret">struct UnityEngine.AccelerationEvent&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAccelerationEvent_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.AccelerationEvent&", 1)]
           public static partial void GET_ACCELERATION_EVENT_INJECTED(System.Int32 index, UnityEngine.AccelerationEvent &ret); 
*/
            /// <summary>
            /// static  System.Single GetAxis(System.String axisName)
            /// </summary>
            /// <param name = "axisName">class System.String</param>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAxis", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial System.Single GET_AXIS(PMonoString axisName);

            /// <summary>
            /// static  System.Single GetAxisRaw(System.String axisName)
            /// </summary>
            /// <param name = "axisName">class System.String</param>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAxisRaw", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial System.Single GET_AXIS_RAW(PMonoString axisName);

            /// <summary>
            /// static  System.Boolean GetButton(System.String buttonName)
            /// </summary>
            /// <param name = "buttonName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetButton", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public static partial System.Boolean GET_BUTTON(nint buttonName); 
*/
            /// <summary>
            /// static  System.Boolean GetButtonDown(System.String buttonName)
            /// </summary>
            /// <param name = "buttonName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetButtonDown", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public static partial System.Boolean GET_BUTTON_DOWN(nint buttonName); 
*/
            /// <summary>
            /// static  System.Boolean GetButtonUp(System.String buttonName)
            /// </summary>
            /// <param name = "buttonName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetButtonUp", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public static partial System.Boolean GET_BUTTON_UP(nint buttonName); 
*/
            /// <summary>
            /// static  System.Int32 GetGyroInternal()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGyroInternal", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial System.Int32 GET_GYRO_INTERNAL(); 
*/
            /// <summary>
            /// static  System.String[] GetJoystickNames()
            /// </summary>
            /// <returns>class System.String[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetJoystickNames", "System.String[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial nint GET_JOYSTICK_NAMES(); 
*/
            /// <summary>
            /// static  System.Boolean GetKey(UnityEngine.KeyCode key)
            /// </summary>
            /// <param name = "key">enum UnityEngine.KeyCode</param>
            /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKey", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.KeyCode", 0)]
            //public static partial System.Boolean GET_KEY(KeyCode key); 

            /// <summary>
            /// static  System.Boolean GetKey(System.String name)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKey", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public static partial System.Boolean GET_KEY(nint name); 
*/
            /// <summary>
            /// static  System.Boolean GetKeyDown(UnityEngine.KeyCode key)
            /// </summary>
            /// <param name = "key">enum UnityEngine.KeyCode</param>
            /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKeyDown", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.KeyCode", 0)]
            //public static partial System.Boolean GET_KEY_DOWN(KeyCode key); 

            /// <summary>
            /// static  System.Boolean GetKeyDown(System.String name)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKeyDown", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public static partial System.Boolean GET_KEY_DOWN(nint name); 
*/
            /// <summary>
            /// static  System.Boolean GetKeyDownInt(UnityEngine.KeyCode key)
            /// </summary>
            /// <param name = "key">enum UnityEngine.KeyCode</param>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKeyDownInt", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.KeyCode", 0)]
            public static partial System.Boolean GET_KEY_DOWN_INT(KeyCode key);

            /// <summary>
            /// static  System.Boolean GetKeyDownString(System.String name)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKeyDownString", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial System.Boolean GET_KEY_DOWN_STRING(PMonoString name);

            /// <summary>
            /// static  System.Boolean GetKeyInt(UnityEngine.KeyCode key)
            /// </summary>
            /// <param name = "key">enum UnityEngine.KeyCode</param>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKeyInt", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.KeyCode", 0)]
            public static partial System.Boolean GET_KEY_INT(KeyCode key);

            /// <summary>
            /// static  System.Boolean GetKeyString(System.String name)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKeyString", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial System.Boolean GET_KEY_STRING(PMonoString name);

            /// <summary>
            /// static  System.Boolean GetKeyUp(UnityEngine.KeyCode key)
            /// </summary>
            /// <param name = "key">enum UnityEngine.KeyCode</param>
            /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKeyUp", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.KeyCode", 0)]
            //public static partial System.Boolean GET_KEY_UP(KeyCode key);

            /// <summary>
            /// static  System.Boolean GetKeyUp(System.String name)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKeyUp", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public static partial System.Boolean GET_KEY_UP(nint name); 
*/
            /// <summary>
            /// static  System.Boolean GetKeyUpInt(UnityEngine.KeyCode key)
            /// </summary>
            /// <param name = "key">enum UnityEngine.KeyCode</param>
            /// <returns>struct System.Boolean</returns>
            
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKeyUpInt", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.KeyCode", 0)]
           public static partial System.Boolean GET_KEY_UP_INT( KeyCode key); 

            /// <summary>
            /// static  System.Boolean GetKeyUpString(System.String name)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKeyUpString", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial System.Boolean GET_KEY_UP_STRING(PMonoString name);

            /// <summary>
            /// static  System.Boolean GetMouseButton(System.Int32 button)
            /// </summary>
            /// <param name = "button">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMouseButton", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial System.Boolean GET_MOUSE_BUTTON(System.Int32 button);

            /// <summary>
            /// static  System.Boolean GetMouseButtonDown(System.Int32 button)
            /// </summary>
            /// <param name = "button">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMouseButtonDown", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial System.Boolean GET_MOUSE_BUTTON_DOWN(System.Int32 button);

            /// <summary>
            /// static  System.Boolean GetMouseButtonUp(System.Int32 button)
            /// </summary>
            /// <param name = "button">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMouseButtonUp", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial System.Boolean GET_MOUSE_BUTTON_UP(System.Int32 button);

            /// <summary>
            /// static  UnityEngine.Touch GetTouch(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct UnityEngine.Touch</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTouch", "UnityEngine.Touch", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public static partial UnityEngine.Touch GET_TOUCH(System.Int32 index); 
*/
            /// <summary>
            /// static  System.Void GetTouch_Injected(System.Int32 index, UnityEngine.Touch& ret)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "ret">struct UnityEngine.Touch&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTouch_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Touch&", 1)]
           public static partial void GET_TOUCH_INJECTED(System.Int32 index, UnityEngine.Touch &ret); 
*/
            /// <summary>
            /// static  System.Void ResetInputAxes()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetInputAxes", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial void RESET_INPUT_AXES(); 
*/
            /// <summary>
            /// static  System.Void set_backButtonLeavesApp(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_backButtonLeavesApp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public static partial void SET_BACK_BUTTON_LEAVES_APP(System.Boolean value); 
*/
            /// <summary>
            /// static  System.Void set_compensateSensors(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_compensateSensors", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public static partial void SET_COMPENSATE_SENSORS(System.Boolean value); 
*/
            /// <summary>
            /// static  System.Void set_compositionCursorPos(UnityEngine.Vector2 value)
            /// </summary>
            /// <param name = "value">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_compositionCursorPos", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
           public static partial void SET_COMPOSITION_CURSOR_POS(UnityEngine.Vector2 value); 
*/
            /// <summary>
            /// static  System.Void set_compositionCursorPos_Injected(UnityEngine.Vector2& value)
            /// </summary>
            /// <param name = "value">struct UnityEngine.Vector2&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_compositionCursorPos_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2&", 0)]
           public static partial void SET_COMPOSITION_CURSOR_POS_INJECTED(UnityEngine.Vector2 &value); 
*/
            /// <summary>
            /// static  System.Void set_eatKeyPressOnTextFieldFocus(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_eatKeyPressOnTextFieldFocus", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public static partial void SET_EAT_KEY_PRESS_ON_TEXT_FIELD_FOCUS(System.Boolean value); 
*/
            /// <summary>
            /// static  System.Void set_imeCompositionMode(UnityEngine.IMECompositionMode value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.IMECompositionMode</param>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_imeCompositionMode", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.IMECompositionMode", 0)]
            public static partial void SET_IME_COMPOSITION_MODE(IMECompositionMode value);

            /// <summary>
            /// static  System.Void set_multiTouchEnabled(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_multiTouchEnabled", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public static partial void SET_MULTI_TOUCH_ENABLED(System.Boolean value); 
*/
            /// <summary>
            /// static  System.Void set_simulateMouseWithTouches(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_simulateMouseWithTouches", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public static partial void SET_SIMULATE_MOUSE_WITH_TOUCHES(System.Boolean value); 
*/
            /// <summary>
            /// static  System.Void SimulateTouch(UnityEngine.Touch touch)
            /// </summary>
            /// <param name = "touch">struct UnityEngine.Touch</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SimulateTouch", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Touch", 0)]
           public static partial void SIMULATE_TOUCH(UnityEngine.Touch touch); 
*/
            /// <summary>
            /// static  System.Void SimulateTouchInternal(UnityEngine.Touch touch, System.Int64 timestamp)
            /// </summary>
            /// <param name = "touch">struct UnityEngine.Touch</param>
            /// <param name = "timestamp">struct System.Int64</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SimulateTouchInternal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Touch", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int64", 1)]
           public static partial void SIMULATE_TOUCH_INTERNAL(UnityEngine.Touch touch, System.Int64 timestamp); 
*/
            /// <summary>
            /// static  System.Void SimulateTouchInternal_Injected(UnityEngine.Touch& touch, System.Int64 timestamp)
            /// </summary>
            /// <param name = "touch">struct UnityEngine.Touch&</param>
            /// <param name = "timestamp">struct System.Int64</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SimulateTouchInternal_Injected", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Touch&", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int64", 1)]
           public static partial void SIMULATE_TOUCH_INTERNAL_INJECTED(UnityEngine.Touch &touch, System.Int64 timestamp); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void CTOR(); 
*/
        }
    }
}