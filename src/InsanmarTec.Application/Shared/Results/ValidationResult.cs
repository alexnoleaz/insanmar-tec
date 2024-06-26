﻿namespace InsanmarTec.Application.Shared.Results
{
    public class ValidationResult
    {
        public bool IsValid => Errors.Count == 0;
        public List<string> Errors { get; private set; }

        public ValidationResult() => Errors = [];
    }
}
