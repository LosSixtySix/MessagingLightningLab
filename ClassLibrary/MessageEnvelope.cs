using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public  class MessageEnvelope:ValueChangedMessage<ObjectWeAreSending>
    {
        public MessageEnvelope(ObjectWeAreSending thing) : base(thing) { }
    }
}
