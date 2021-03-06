﻿using System;

namespace TaskDialogs.Classes
{
    [Flags]
    public enum TaskDialogButtons : int
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0,

        /// <summary>
        /// 
        /// </summary>
        OK = 1 << 0,

        /// <summary>
        /// 
        /// </summary>
        Yes = 1 << 1,

        /// <summary>
        /// 
        /// </summary>
        No = 1 << 2,

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Note: Adding a Cancel button will automatically add a close button
        /// to the task dialog's title bar and will allow to close the dialog by
        /// pressing ESC or Alt+F4 (just as if you enabled
        /// <see cref="TaskDialogPage.AllowCancel"/>).
        /// </remarks>
        Cancel = 1 << 3,

        /// <summary>
        /// 
        /// </summary>
        Retry = 1 << 4,

        /// <summary>
        /// 
        /// </summary>
        Close = 1 << 5,

        /// <summary>
        /// 
        /// </summary>
        Abort = 1 << 16,

        /// <summary>
        /// 
        /// </summary>
        Ignore = 1 << 17,

        /// <summary>
        /// 
        /// </summary>
        TryAgain = 1 << 18,

        /// <summary>
        /// 
        /// </summary>
        Continue = 1 << 19,

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Note: Clicking this button will not close the dialog, but will raise the
        /// <see cref="TaskDialogPage.Help"/> event.
        /// </remarks>
        Help = 1 << 20
    }

    public enum TaskDialogCommandLinkMode
    {
        /// <summary>
        /// Custom buttons should be displayed as normal buttons.
        /// </summary>
        None = 0,

        /// <summary>
        /// Custom buttons should be displayed as command links.
        /// </summary>
        CommandLinks = 1,

        /// <summary>
        /// Custom buttons should be displayed as command links, but without an icon.
        /// </summary>
        CommandLinksNoIcon = 2
    }

    public enum TaskDialogIcon : int
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0,

        /// <summary>
        /// 
        /// </summary>
        Information = ushort.MaxValue - 2, // TD_INFORMATION_ICON

        /// <summary>
        /// 
        /// </summary>
        Warning = ushort.MaxValue, // TD_WARNING_ICON

        /// <summary>
        /// 
        /// </summary>
        Error = ushort.MaxValue - 1, // TD_ERROR_ICON

        /// <summary>
        /// 
        /// </summary>
        SecurityShield = ushort.MaxValue - 3, // TD_SHIELD_ICON

        /// <summary>
        /// 
        /// </summary>
        SecurityShieldBlueBar = ushort.MaxValue - 4,

        /// <summary>
        /// 
        /// </summary>
        SecurityShieldGrayBar = ushort.MaxValue - 8,

        /// <summary>
        /// 
        /// </summary>
        SecurityWarningYellowBar = ushort.MaxValue - 5,

        /// <summary>
        /// 
        /// </summary>
        SecurityErrorRedBar = ushort.MaxValue - 6,

        /// <summary>
        /// 
        /// </summary>
        SecuritySuccessGreenBar = ushort.MaxValue - 7,

        //// TODO: Check if the following icons should be included.
        //// These icons are used from the system's resource module (imageres.dll)
        //// and can be used when specifying NULL in the TaskDialogConfig's hInstance
        //// field (which we currently always do).
        //// For more information, see:
        //// https://docs.microsoft.com/en-us/windows/desktop/Controls/tdm-update-icon
        //// However, if we allow to specify the hInstance in the future, these enum
        //// values would no longer be valid, so we probably shouldn't add them.
        //// Note: The 32xxx values are taken from WinUser.h (prefix "OIC_").

        ///// <summary>
        ///// 
        ///// </summary>
        //InformationNoSound = 32516, // OIC_INFORMATION

        ///// <summary>
        ///// 
        ///// </summary>
        //WarningNoSound = 32515, // OIC_WARNING

        ///// <summary>
        ///// 
        ///// </summary>
        //StopNoSound = 32513, // OIC_ERROR

        ///// <summary>
        ///// 
        ///// </summary>
        //QuestionNoSound = 32514, // OIC_QUES

        ///// <summary>
        ///// 
        ///// </summary>
        //SecurityQuestion = 104,

        ///// <summary>
        ///// 
        ///// </summary>
        //SecurityError = 105,

        ///// <summary>
        ///// 
        ///// </summary>
        //SecuritySuccess = 106,

        ///// <summary>
        ///// 
        ///// </summary>
        //SecurityWarning = 107
    }

    public enum TaskDialogProgressBarState : int
    {
        /// <summary>
        /// Shows a regular progress bar.
        /// </summary>
        Normal = 0,

        /// <summary>
        /// Shows a paused (yellow) progress bar.
        /// </summary>
        Paused,

        /// <summary>
        /// Shows an error (red) progress bar.
        /// </summary>
        Error,

        /// <summary>
        /// Shows a marquee progress bar.
        /// </summary>
        Marquee,

        /// <summary>
        /// Shows a marquee progress bar where the marquee animation is paused.
        /// </summary>
        /// <remarks>
        /// For example, if you switch from <see cref="Marquee"/> to 
        /// <see cref="MarqueePaused"/> while the dialog is shown, the 
        /// marquee animation will stop.
        /// </remarks>
        MarqueePaused,

        /// <summary>
        /// The progress bar will not be displayed.
        /// </summary>
        /// <remarks>
        /// Note that while the dialog is showing, you cannot switch from
        /// <see cref="None"/> to any other state, and vice versa.
        /// </remarks>
        None
    }

    public enum TaskDialogResult : int
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0,

        /// <summary>
        /// 
        /// </summary>
        OK = TaskDialogNativeMethods.IDOK,

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Note: Adding a Cancel button will automatically add a close button
        /// to the task dialog's title bar and will allow to close the dialog by
        /// pressing ESC or Alt+F4 (just as if you enabled
        /// <see cref="TaskDialogPage.AllowCancel"/>).
        /// </remarks>
        Cancel = TaskDialogNativeMethods.IDCANCEL,

        /// <summary>
        /// 
        /// </summary>
        Abort = TaskDialogNativeMethods.IDABORT,

        /// <summary>
        /// 
        /// </summary>
        Retry = TaskDialogNativeMethods.IDRETRY,

        /// <summary>
        /// 
        /// </summary>
        Ignore = TaskDialogNativeMethods.IDIGNORE,

        /// <summary>
        /// 
        /// </summary>
        Yes = TaskDialogNativeMethods.IDYES,

        /// <summary>
        /// 
        /// </summary>
        No = TaskDialogNativeMethods.IDNO,

        /// <summary>
        /// 
        /// </summary>
        Close = TaskDialogNativeMethods.IDCLOSE,

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Note: Clicking this button will not close the dialog, but will raise the
        /// <see cref="TaskDialogPage.Help"/> event.
        /// </remarks>
        Help = TaskDialogNativeMethods.IDHELP,

        /// <summary>
        /// 
        /// </summary>
        TryAgain = TaskDialogNativeMethods.IDTRYAGAIN,

        /// <summary>
        /// 
        /// </summary>
        Continue = TaskDialogNativeMethods.IDCONTINUE
    }

    public enum TaskDialogStartupLocation
    {
        /// <summary>
        /// 
        /// </summary>
        CenterScreen = 0,

        /// <summary>
        /// 
        /// </summary>
        CenterParent = 1
    }
}