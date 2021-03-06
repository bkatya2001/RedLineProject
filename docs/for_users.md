# Руководство пользователя

## 1 Общие сведения о программном продукте

Задача программного продукта заключается в `определении количества листов ДСП указанного размера достаточного для создания введённого набора деталей`. Система позволяет указать размеры листа ДСП и деталей, а также размер фрезы.
Работа с приложением может осуществляться с любого компьютера или ноутбука с операционной системой Windows.
***

## 2 Инструкция по работе с приложением

Для начала расчётов необходимо указать размеры ДСП, а именно длину и ширину в миллиметрах, и размер фрезы. Программа автоматически учитывает, что станок обрезает лист с краёв (10 мм). Под размером фрезы понимается расстояние в миллиметрах между двумя деталями на листе.

Для выполнения расчётов необходимо указать параметры всех деталей. Деталь вводится в программу после указания её длины и ширины в миллиметрах, а также количества, при нажатии на кнопку «Добавить».

Все добавленные детали отображаются в таблице справа в формате

`Длина *  Ширина`; `Количество.`

Для выполнения расчётов необходимо нажать на кнопку «Рассчитать». Результат появится во всплывающем окне.

***

    Во всех полях для ввода необходимо указать числа, иначе возможно получить следующие сообщения от программы:

1.  Длина или ширина детали меньше или равны нолю или количество меньше 1.

***
2. В поле ввода указаны символы, не являющиеся цифрами.

***
3. Фреза, длина или ширина листа ДСП меньше или равны нолю.

***
4. Среди введённых деталей есть такие, размеры которых превышают размер листа ДСП. Все данные необходимо ввести заново.

***
