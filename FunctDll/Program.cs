using System;
using AddFunction;


namespace FunctDll
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] LessonsList = new string[7];
            LessonsList[0] = "Введите 1,если хотите вывести на экран алгоритм проверки, простое число или нет.";
            LessonsList[1] = "Введите 2,если хотите вывести на экран функцию вычисления числа Фибоначчи без рекурсии";
            LessonsList[2] = "Введите 3,если хотите вывести на экран функцию вычисления числа Фибоначчи с помощью рекурсии";
            LessonsList[3] = "Введите 4,если хотите вывести двусвязный список";
            LessonsList[4] = "Введите 5,если хотите вывести расчет дистанции";
            LessonsList[5] = "Введите 6,если хотите вывести поиск бинарного дерева";
            LessonsList[6] = "Введите 7,если хотите реализовать  алгоритм задачи на количество вариантов и вывод количества вариантов для последовательности";
            for (int i = 0; i < LessonsList.Length; i++)
            {
                Console.WriteLine(LessonsList[i]);
            }
            var vvod = Console.ReadLine();
            if (vvod == "1")
            {
                Function.Block BlockShema = new Function.Block();
                BlockShema.work();
            }
            else if (vvod == "2")
            {
                Function.bezFibonachi bezRecursionFibonachi = new Function.bezFibonachi();
                bezRecursionFibonachi.bFibonachi();
            }
            else if (vvod == "3")
            {
                Function.recFibonachi RecursionFibonachi = new Function.recFibonachi();
                RecursionFibonachi.recursionFibonachi();
            }
            else if (vvod == "4")
            {
                Function.DoubleLinkedList DoubleLinkedList = new Function.DoubleLinkedList();
                DoubleLinkedList.AddNode(20);
                DoubleLinkedList.PrintList();
            }
            else if (vvod == "5")
            {
                Function.Output output = new Function.Output();
                output.OutputScreen();  
            }
            else if (vvod == "6")
            {
                Function.BinaryTree tree = new Function.BinaryTree();
                Function.BinaryTreeExtensions PrintExtensions = new Function.BinaryTreeExtensions();
                tree.Insert(20);
                tree.Insert(40);
                tree.Insert(10);
                tree.Insert(30);
                tree.Insert(80);
                tree.Insert(29);
                tree.Insert(31);
                tree.Insert(32);
                tree.Insert(70);
                PrintExtensions.Print(tree);
                tree.Remove(80);
                PrintExtensions.Print(tree);
                tree.Remove(29);
                PrintExtensions.Print(tree);

                
                Function.SearchDFS searchDFS = new Function.SearchDFS(5);
                searchDFS.Add(0, 1);
                searchDFS.Add(0, 2);
                searchDFS.Add(1, 1);
                searchDFS.Add(1, 2);
                searchDFS.Add(2, 0);
                searchDFS.Add(2, 3);
                searchDFS.Add(3, 4);
                Console.WriteLine("поиск в глубину");
                searchDFS.DFSSer(2);

                Function.SearchBFS searchBFS = new Function.SearchBFS(5);
                searchBFS.Add(0, 1);
                searchBFS.Add(0, 2);
                searchBFS.Add(1, 1);
                searchBFS.Add(1, 2);
                searchBFS.Add(2, 0);
                searchBFS.Add(2, 3);
                searchBFS.Add(3, 4);
                Console.WriteLine("\nпоиск в ширину");
                searchBFS.BFS(2);

            }
            else if (vvod == "7")
            {
                Function.Chess Chess = new Function.Chess();
                Chess.Start();
            }
        }
    }
}
