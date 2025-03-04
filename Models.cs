﻿public class Message
{
    public string role { get; set; }
    public string content { get; set; }
}

public class ChatCompletionResponse
{
    public string id { get; set; }
    public string @object { get; set; }
    public long created { get; set; }
    public string model { get; set; }
    public Usage usage { get; set; }
    public Choice[] choices { get; set; }
}

public class Usage
{
    public int prompt_tokens { get; set; }
    public int completion_tokens { get; set; }
    public int total_tokens { get; set; }
}

public class Choice
{
    public Message message { get; set; }
    public string finish_reason { get; set; }
    public int index { get; set; }
}

public class ErrorResponse
{
    public Error error { get; set; }
}

public class Error
{
    public string message { get; set; }
    public string type { get; set; }
    public string param { get; set; }
    public string code { get; set; }
}