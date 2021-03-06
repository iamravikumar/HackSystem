﻿using System;
using HackSystem.Observer.Publisher;
using HackSystem.Web.ProgramSDK.ProgramComponent.ProgramMessages;
using Microsoft.AspNetCore.Components;

namespace HackSystem.Web.ProgramSDK.ProgramComponent
{
    public abstract class ProgramComponentBase : ComponentBase, IDisposable
    {
        [Inject]
        public IPublisher<ProgramCloseMessage> ProgramClosePublisher { get; set; }

        [Parameter]
        public int PID { get; set; }

        private ProgramEntity programEntity;

        [Parameter]
        public ProgramEntity ProgramEntity { get => programEntity; set => programEntity = value; }

        public virtual void OnClose()
        {
            this.ProgramClosePublisher.Publish(new ProgramCloseMessage(this.PID));
        }

        public abstract void Dispose();
    }
}
