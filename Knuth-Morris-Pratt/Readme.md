### Результаты сравнения скорости работы по поиску текста конечным автоматом и алгоритмом Кнута-Морриса-Пратта

#### Скорость работы алгоритмов (мс):

Алгоритм  | 1000 итераций| 10 000 итераций | 100 000 итераций | 1 000 000 итераций
------------- | :-------------: | :-------------: | :-------------: | :-------------:
**Конечный автомат**                                               | 8 | 73   | 734  | 6538
**КМП префикс-функция, медленный вариант**| 2   |  21  |  220  | 2208
**КМП префикс-функция, быстрый вариант**     |  0   |  3   |  38  | 392

###### Вывод:
Наиболее быстрым из  3-x алгоритмов - алгоритм  Кнута-Морриса-Пратта с быстрым вариантом нахождения вектора длин префиксов строк.
На последнем месте с большим отставанием идет конечный автомат.