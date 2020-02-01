﻿using System.Windows.Controls;

namespace Its.Onix.Ui.Client.Commons.Forms
{
    public class UserControlBase : UserControl
    {
        public IForm FormWrapper { get; set; }
        protected UserControlBase ParentContainer { get; set; }

        public UserControlBase(UserControlBase parent)
        {
            ParentContainer = parent;
        }

        protected virtual void Close()
        {
        }

        protected void NotifyParentToClose()
        {
            if (ParentContainer != null)
            {
                ParentContainer.Close();
            }
        }
    }
}