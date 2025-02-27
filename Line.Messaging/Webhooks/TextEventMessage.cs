namespace Line.Messaging.Webhooks
{
    /// <summary>
    /// Message object which contains the text sent from the source.
    /// </summary>
    public class TextEventMessage : EventMessage
    {
        public string Text { get; }
        public bool IsCheck { get; }

        public TextEventMessage(string id, string text, bool isCheck) : base(EventMessageType.Text, id)
        {
            Text = text;
            IsCheck = isCheck;
        }
    }
}
