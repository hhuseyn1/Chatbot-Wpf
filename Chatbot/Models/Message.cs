using System;

namespace Chatbot.Models;

public class Message{
    public string? Sender { get; set; } 
    public string? MessageText { get; set; }
    public DateTime? SendedTime { get; set; } 
}
