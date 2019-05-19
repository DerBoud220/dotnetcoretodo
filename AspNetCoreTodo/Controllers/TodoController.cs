using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreTodo.Services;
//pg 30 in littleasp book

namespace AspNetCoreTodo.Controllers {
    public class TodoController : Controller {
        // Actions will go here
        // Routes that are handled by controllers are called actions
        // These are represented by methods in the controller class
        private readonly ITodoItemService _todoItemService;
        public TodoController(ITodoItemService todoItemService) {
            _todoItemService = todoItemService;
        }
        public async Task<IActionResult> Index() {
            // get to do items from database
            // put items into a model
            // pass the view to a model and render
            var items = await _todoItemService.GetIncompleteItemsAsync();
        }
    }
}