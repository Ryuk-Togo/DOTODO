using System;
using System.Collections.Generic;
using System.Text;

namespace DOTODO
{
    class TodayTodoList
    {
        private String date;
        private String day;
        private String todo;

        public string Date { get => date; set => date = value; }
        public string Day { get => day; set => day = value; }
        public string Todo { get => todo; set => todo = value; }

        public TodayTodoList(String date, String day, String todo)
        {
            this.date = date;
            this.day = day;
            this.todo = todo;
        }
    }
}
