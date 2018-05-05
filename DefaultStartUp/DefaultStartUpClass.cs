﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StartUpTemplate;
using System.Windows.Forms;

namespace DefaultStartUp
{
    public class DefaultStartUpClass : StartUpTemplateClass
    {
        public DefaultStartUpClass()
        {
            this.Name = "默认启动画面";
            this.Description = "默认的启动画面 ...";
        }

        protected override Form CreateStartUpForm()
        {
            DefaultStartUpForm FormInstance = new DefaultStartUpForm();
            FormInstance.FormClosing += new FormClosingEventHandler((s,e)=> { OnStartUpFinished(EventArgs.Empty); });
            return FormInstance;
        }
    }
}