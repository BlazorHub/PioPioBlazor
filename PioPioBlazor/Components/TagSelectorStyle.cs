﻿namespace PioPioBlazor.Components
{
    public class TagSelectorStyle
    {
        public static readonly TagSelectorStyle TailwindCss = new TagSelectorStyle
        {
            SelectorClass =
                "block appearance-none w-full bg-white border border-gray-400 hover:border-gray-500 px-4 py-2 pr-8 rounded shadow leading-tight focus:outline-none focus:shadow-outline mb-8 md:w-5/12",
            SelectedTagClass =
                "bg-blue-300 hover:bg-blue-700 text-white font-bold py-1 px-2 rounded-full cursor-pointer",
            DropdownClass = "bg-white shadow rounded-lg py-2 z-10",
            DropdownItemClass = "block px-4 py-2 text-gray-80 hover:bg-indigo-500",
            DropdownItemHoverClass = "bg-indigo-500",
            InputBoxClass = "",
            RemoveTagClass = ""
        };

        public string SelectorClass { get; set; } = string.Empty;
        public string SelectedTagClass { get; set; } = string.Empty;
        public string DropdownClass { get; set; } = string.Empty;
        public string DropdownItemClass { get; set; } = string.Empty;
        public string DropdownItemHoverClass { get; set; } = string.Empty;
        public string InputBoxClass { get; set; } = string.Empty;
        public string RemoveTagClass { get; set; } = string.Empty;
    }
}