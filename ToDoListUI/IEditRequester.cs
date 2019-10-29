using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListLibrary.Models;

namespace ToDoListUI
{
    public interface IEditRequester
    {
        void EditComplete(TaskModel model);
    }
}
