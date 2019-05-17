using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models {
    public class TodoItem {
        public Guid Id {get; set;}
        public bool IsDone {get; set;}
        //required means that Title is required and is cannot be null/empty
        [Required]
        public string Title {get; set;}
        public DateTimeOffset? DueAt {get; set;}
        //the ? makes this attribute nullable, meaning we aren't forced to include it like the other pieces.
    }
}