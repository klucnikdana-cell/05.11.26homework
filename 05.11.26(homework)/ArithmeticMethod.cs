using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _05._11._26_homework_
{
    internal class ArithmeticMethod
    {
        public static T Sum<T>(T[] numbers) where T : INumber<T> //INumber = він визначає сам тип числа,і може робити + - і таке подібне(але ми не повинні просто прописати INumber 
            //і все,бо ми маємо дати йому пасхалку(шлях).Типу,чи йому йти по масиву та додавати чи віднімати,чи знаходити менше та більше число і тд
        {
            T sum = T.Zero;//Залежний від INumber.Просто так ми не можемо прописати.Щоб кожному числу не задавати 0(почати рахувати з 0),то для цього ми можемо прописати Zero
            //і воно буде приймаися не тільки для нашого числа одного,а до всіх - просто записавши Zero

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
