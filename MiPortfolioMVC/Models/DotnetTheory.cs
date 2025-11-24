namespace DotnetTheory
{
    public class Theory
    {
        // This class can be expanded with properties and methods related to .NET theory.
    }
    public class CodeSnippets
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        [Required, StringLength(30)]
        public string Language { get; set; } // In this case is it safe in dotnet context
        [Required]
        public string Code { get; set; } // We store the code snippet here.
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}