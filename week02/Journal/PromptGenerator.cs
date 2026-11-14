using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    private int _lastPromptIndex = -1;

    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What am I most grateful for today?");
        _prompts.Add("What challenge did I face today, and how did I overcome it?");
        _prompts.Add("What did I learn today that will help me become a better person?");
        _prompts.Add("Did I make a positive difference in someone's life today?");
        _prompts.Add("What is one thing I want to improve or accomplish tomorrow?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        
        while (index == _lastPromptIndex)
        {
            index = random.Next(_prompts.Count);
        }

        _lastPromptIndex = index;
        return _prompts[index];
    }
}