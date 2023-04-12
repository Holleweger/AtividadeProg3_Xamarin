using DoToo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DoToo.ViewModels
{
    public class TodoItemViewModel : ViewModel
    {
        public TodoItem Item { get; private set; }

        public TodoItemViewModel(TodoItem item) => Item = item;

        public event EventHandler ItemStatusChanged;




    }
}
