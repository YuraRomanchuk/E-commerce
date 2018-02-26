﻿using RozetkaTestAutomationFrameworkUsage.Extensions;
using OpenQA.Selenium;

namespace RozetkaTestAutomationFrameworkUsage.Elements
{
    public class Button : Element
    {
        public Button(IWebElement nativeElement) : base(nativeElement) { }

        public string GetText()
        {
            var result = Text;
            if (result.IsNullOrEmpty())
                result = GetAttribute("value");
            return Text?.Trim();
        }
    }
}