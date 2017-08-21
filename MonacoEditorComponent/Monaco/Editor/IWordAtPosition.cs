﻿using Newtonsoft.Json;

namespace Monaco.Editor
{
    /// <summary>
    /// https://microsoft.github.io/monaco-editor/api/interfaces/monaco.editor.iwordatposition.html
    /// </summary>
    public interface IWordAtPosition
    {
        /// <summary>
        /// Column where the word ends.
        /// </summary>
        [JsonProperty("endColumn")]
        uint EndColumn { get; }

        /// <summary>
        /// Column where the word starts.
        /// </summary>
        [JsonProperty("startColumn")]
        uint StartColumn { get; }

        /// <summary>
        /// The word.
        /// </summary>
        [JsonProperty("word")]
        string Word { get; }
    }
}
