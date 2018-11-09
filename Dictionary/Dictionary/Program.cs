using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary neu;
            int ersteauswahl;
            int zweiteauswahl;
            int dritteauswahl;
            int daten;
            bool weiter = true;

            ersteauswahl = Convert.ToInt32(Console.ReadLine());
            // 1 ist SetSorted
            //2 ist SetUnsorted
            //3 ist Multisetsorted
            //4 ist Multisetunsorted


            /* Zweiteauswahl:
             * 
             * erst array
             * dann liste
             * dann bin
             * dann avl
             * dann treap
             * 
             * 
             */
            switch (ersteauswahl)
            {
                case 1:
                    {
                        zweiteauswahl = Convert.ToInt32(Console.ReadLine());
                        switch (zweiteauswahl)
                        {
                            case 1:
                                {
                                    neu = new SetSortedArray();
                                    break;
                                }
                            case 2:
                                {
                                    neu = new SetSortedLinkedList();
                                    break;
                                }
                            case 3:
                                {
                                    neu = new BinSearchTree();
                                    break;
                                }
                            case 4:
                                {
                                    neu = new AVLTree();
                                    break;
                                }
                            case 5:
                                {
                                    neu = new Treap();
                                    break;
                                }

                            default:
                                break;
                        }
                        break;
                    }
                case 2:
                    {
                        zweiteauswahl = Convert.ToInt32(Console.ReadLine());
                        switch (zweiteauswahl)
                        {
                            case 1:
                                {
                                    neu = new SetUnsortedArray();
                                    break;
                                }
                            case 2:
                                {
                                    neu = new SetUnsortedLinkedList();
                                    break;
                                }
                            default:
                                break;
                        }
                        
                        break;
                    }
                case 3:
                    {
                        zweiteauswahl = Convert.ToInt32(Console.ReadLine());
                        switch (zweiteauswahl)
                        {
                            case 1:
                                {
                                    neu = new MultiSetSortedArray();
                                    break;
                                }
                            case 2:
                                {
                                    neu = new MultiSetSortedLinkedList();
                                    break;
                                }
                            default:
                                break;
                        }

                        break;
                    }
                case 4:
                    {
                        zweiteauswahl = Convert.ToInt32(Console.ReadLine());
                        switch (zweiteauswahl)
                        {
                            case 1:
                                {
                                    neu = new MultiSetUnsortedArray();
                                    break;
                                }
                            case 2:
                                {
                                    neu = new MultiSetUnsortedLinkedList();
                                    break;
                                }
                            default:
                                break;
                        }

                        break;
                    }
                default:
                        break;
            }


            while (weiter == true)
            {
                
                switch (dritteauswahl)
                {
                    case 1:
                        {
                            neu.print();
                            break;
                        }
                    case 2:
                        {
                            dritteauswahl = Convert.ToInt32(Console.ReadLine());
                            daten = Convert.ToInt32(Console.ReadLine());
                            if (daten < 0)
                            {
                                throw new ArgumentOutOfRangeException("Darf nicht kleiner 0 sein!");
                            }
                            neu.delete(daten);
                            break;
                        }
                    case 3:
                        {
                            dritteauswahl = Convert.ToInt32(Console.ReadLine());
                            daten = Convert.ToInt32(Console.ReadLine());
                            if (daten < 0)
                            {
                                throw new ArgumentOutOfRangeException("Darf nicht kleiner 0 sein!");
                            }
                            neu.search(daten);
                            break;
                        }
                    case 4:
                        {
                            dritteauswahl = Convert.ToInt32(Console.ReadLine());
                            daten = Convert.ToInt32(Console.ReadLine());
                            if (daten < 0)
                            {
                                throw new ArgumentOutOfRangeException("Darf nicht kleiner 0 sein!");
                            }
                            neu.insert(daten);
                            break;
                        }
                    default:
                        break;
                }
            }
        }

    }
}
