using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*
 * Homework #1

1. Скачайте репозиторий решения CSharp_Advanced. Можно сделать
download, а можно использовать fork, а потом выкачать уже из личного
профиля.
2. В проекте создайте из master ветки новую ветку с названием
hw1_%фамилия% (пример – hw1_svyrydenko).
3. Откройте проект 1_Collections. Это домашнее задание должно относиться
к этому проекту.
4. Ваша задача – реализовать все методы интерфейса IBaseCollectionUsing в
5. Пример можно увидеть в ArrayListUsing, в данном случае сделано на
основе коллекции типа ArrayList. Вы должны сделать аналогично для
List<string> в GenericListUsing. Прошу обратить внимание на
необходимость обрабклассах DictionaryUsing и GenericListUsing.

отки исключений.

6. В случае с DictionaryUsing вам нужно создать свою систему ключей, по
которым вы будете хранить данные в вашем словаре. Алгоритм должен
выглядеть следующим образом:
a. Полученный объект приводим к строке;
b. Создаем уникальный ключ, по которому будем сохранять его в
словаре (например, проходим по всему словарю и ищем
максимальное значение Key, для нового элемента увеличиваем его
на единицу (инкрементим));
c. Добавляем ключ-значение в словарь.

7. Для проверки правильной работы разработанного класса ...Using нужно
вызвать BaseUsingTest.Execute, передавая параметром объект Using. При
необходимости вторым параметром можно передать массив объектов для
проверки (в классе BaseUsingTest в 14 строке можно увидеть базовые
значения данного параметра).
8. Данная строка в консоли свидетельствует об успешном выполнении теста:

9. Дополнительно для лучшего понимания темы можно реализовать команды
для добавления/удаления/извлечения элементов через ...Using из консоли.
 */

/*
 * Стяните последние изменения с репозитория CSharp_Advanced. Ссылки
как делать fork и update репозитория.
2. В проекте создайте из master ветки новую ветку с названием
hw2_%фамилия% (пример – hw2_svyrydenko).
3. Заходим в проект 2_Collections. Это домашнее задание должно относиться
к этому проекту.
4. Ваша задача – реализовать IteaGenericEnumerator, затем –
IteaGenericCollection. По сути, цель – создать собственную реализацию
List.
5. Так же необходимо в IteaGenericCollection создать собственный метод,
который с помощью yield будет возвращать данные по условию. Например,
вернуть только те объекты, которые в массиве имеют непарный индекс.
6. Для проверки правильной работы разработанного класса
IteaGenericCollection нужно вызвать BaseGenericUsingTest.Execute<T> (где
T – тип, который указан при создании IteaGenericCollection), передавая
параметром объект IteaGenericCollection. Вторым параметром нужно
передать массив объектов для проверки.
 */
namespace TryCatchFinallyInEachClass
{
    class NewUserInfo : System.Collections.IEnumerable
    {

     //  public static IEnumerable<int, string> enumerdict(int i){
     //!!!
      //      return enumerdict;
       //     }

        public static Dictionary<int, string> mydict(int i)
        {
            Dictionary<int, string> mydict = new Dictionary<int, string>();
            Console.WriteLine("Value please");
            string s;
            for (int j = 0; j < i; j++)
            {
                Console.Write("Name {0} --> ", j);
                s = Console.ReadLine();
                mydict.Add(j, s);
                Console.Clear();
            }
            return mydict;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
