﻿namespace TodoApi.Models;

public class TodoItem 
{
    public string? Secret { get; set; }
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}