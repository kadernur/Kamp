using System;
using System.Collections.Generic;
using System.Text;

namespace GenericIntro
{
    class MyList<T>
    {
        T [] items;
        //Constructor
        public MyList()
        {
            items = new T[0]; //newlediğimiz anda çalışan bloğa const. denir.


        }
        //metodun dışında yazdığım yöntem classta oldugu için erişim sağlanabilir.

        public void Add(T item)
        {
            //geçiçi dizinin referansı items'ın referansı.
            //elemanlarımın kaybolmasını engeller.

            T[] tempArray = items;
            items = new T[items.Length+1];
            //dizinin eleman sayısını ++ yapıyoruz.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];


            }

            items[items.Length - 1] = item; 
            //eklemek istediğim elemanı şuan ekleyebildim.





        }

    }
}
