﻿namespace Maple.MonoGameAssistant.AndroidCore.AndroidTask
{
    internal sealed class AndroidTaskState_ActionArgs<T_CONTEXT, T_Args>(T_CONTEXT context, Action<T_CONTEXT, T_Args> action, T_Args args)
    : AndroidTaskState<T_CONTEXT>(context)
    where T_CONTEXT : class
    where T_Args : notnull
    {
        public Action<T_CONTEXT, T_Args> Action { get; } = action;
        public T_Args Args { get; } = args;

        public bool Execute()
        {
            Action.Invoke(Context, Args);
            return true;
        }
    }

}
