﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication2;

namespace FMClasses
{
    class KontrolClass : DataGridView//listview, наследовать от него, поменять на форме гриды на листвью
    {
        private void InitializationComponent()
        {
            
        }
        public KontrolClass()
        {
            InitializationComponent();
            var dgView = new DataGridView();
            dgView.Columns.Add(Name,"Name");
            dgView.Columns.Add(Name, "Size");
        }

        public void LoadNode(Node[] nodes)//массив
        {
            string c = @"C:\";
            var fales = new Files { Per = c };
            this.Rows.Add(fales.Name,fales.Size);
        }
    }
}
//контрол - специальный класс, который отображает один из визуальных объектов. Используется для того, чтобы
//не нагромождать код в коде программы. В контроле формируется функционал для поведения объекта на форме, может быть вынесен
//в отдельную сборку, для дальейшего использования всеми объектами, для которых делался контрол(в данном случае DataGridView)

//принимает список нодов(Node) для отображения - некий метод Load -  загружает список наследников и отображает их.
//после этого - отображать.
// принимаем класс(список операций коасса), который наследуется от списка Node, для получения списка всех их операций.
//свои функции не писать, я работаю только над выводом и отображением того, что выложат на гит
//сделать какой-то свой класс Nodе, пустой, чтобы просто проверить его работу, когда все получиться - заменить его на настоящий
//три сборки - 1) внешний вид, 2)контрол - вот это, 3)сам Ноде, в котором список всех методов.

//создать свой метод, де будет инициаоизироваться контрол мой, юзерконтрол - в нем будет 2 кнопки и грид, и его размесстить на форме, вместо грида и 2-х кнопок
//методы исправить, загрузка файлов происходит в контроле
