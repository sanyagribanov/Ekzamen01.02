# Экзамен 04.07.2022

![изображение](https://user-images.githubusercontent.com/86486142/177054671-c2b5bed1-c390-4927-a98a-7bb20739db9e.png)

---
**Приемочное тестирование**<br>
  *Терминология*<br>
  В тестировании программного обеспечения ISTQB определяет приемочное тестирование как:<br>
Формальное тестирование потребностей, требований и бизнес-процессов пользователей, проводимое для определения того, удовлетворяет ли система критериям приемки, и для того, чтобы дать возможность пользователю, клиентам или другому уполномоченному органу определить, следует ли принимать систему.<br>

  *Обзор*<br>
  Тестирование — это набор действий, проводимых для облегчения обнаружения и/или оценки свойств одного или нескольких тестируемых элементов. Каждый отдельный тест, известный как тестовый пример, выполняет набор предопределенных тестовых действий, разработанных для управления выполнением элемента теста для достижения целей теста; включая правильную реализацию, идентификацию ошибок, проверку качества и другие ценные детали. Тестовая среда обычно разрабатывается так, чтобы быть идентичной или максимально близкой к ожидаемой производственной среде. Он включает в себя все средства, оборудование, программное обеспечение, микропрограммы, процедуры и/или документацию, предназначенные или используемые для выполнения тестирования программного обеспечения.<br>
   Приемочное тестирование выполняется на основании набора типичных тестовых случаев и сценариев, разработанных на основании требований к данному приложению.
Решение о проведении приемочного тестирования принимается, когда:<br>
- продукт достиг необходимого уровня качества;
- заказчик ознакомлен с Планом Приемочных Работ (Product Acceptance Plan) или иным документом, где описан набор действий, связанных с проведением приемочного тестирования, дата проведения, ответственные и т.д.<br>
Фаза приемочного тестирования длится до тех пор, пока заказчик не выносит решение об отправлении приложения на доработку или выдаче приложения.<br>

*Цели*
* Определить, соответствует ли система приемочным критериям.
* Решить, одобрить ли релиз продукта или отправить обратно на дальнейшую разработку.<br>

*Объекты*
- Эксплуатация.
- Процессы эксплуатации и обслуживания.
- Бизнес-процессы для полностью интегрированной системы.
- Отчеты.<br>

*Базис тестирования*<br>
Базис тестирования - это документ, на основании которого определяются требования к компоненту или системе. Документация, на которой базируются тестовые сценарии. Если правка данного документа может быть осуществлена только в процессе формальной процедуры внесения изменения, то такой базис тестирования называется замороженным базисом тестирования.<br>

*Критерии приемочного тестирования*
- Критерии приемки определяются на основе следующих атрибутов:
- Функциональная правильность и полнота
- Целостность данных
- Конверсия данных
- Юзабилити
- Конфиденциальность и доступность
- Устанавливаемость и Обновляемость
- Документация и т.д.<br>

Если программный продукт не соответствует одному или нескольким из заданных критиериев, то он выходит из приемочного тестирования на доработку.<br>

*Измерения и метрики*<br>
Метрика — технически или процедурно измеримая величина, характеризующая состояние объекта управления.<br>
KPI – метрика, которая служит индикатором состояния объекта управления. Обязательное условие – наличие целевого значения и установленные допустимые отклонения.<br>
Метрика KPI также описывается при помощи следующих формул:<br>
![изображение](https://user-images.githubusercontent.com/86486142/176209385-229c5847-c6bd-46b1-8f05-275a481afa24.png)<br>
На основе этих данных можно составить *коэффициент тяжести*, для того, чтобы добавить важность запроса для окончательного расчета. Пусть деление будет следующим:
* Critical (KT = 5);
* Major (3 < KT < 5);
* Minor (KT < 3).<br>
После получения коэффициента тяжести (КТ) мы вводим значения весов и рейтинга<br>
Вес — это значение, которое необходимо нам для того, чтобы сделать наименьшим влияние запросов на итоговую оценку с низким коэффициентом тяжести, и  наоборот, запрос с наибольшим коэффициентом тяжести имеет серьезное влияние на оценку, при условии того, что мы просрочили сроки по данному запросу.<br>
Вычисление веса:<br>
![изображение](https://user-images.githubusercontent.com/86486142/176212099-6f58b598-5213-43ca-8bf8-c97b6229361d.png)<br>

Рейтинг – это величина, характеризующая важность нашего запроса для расчета итогового показателя<br>
Вычисление рейтинга:<br>
![изображение](https://user-images.githubusercontent.com/86486142/176212473-858c53b3-3298-49d4-ae2f-9dd6b5ae5ca7.png)<br>

В итоге получаем итоговый показатель метрики:<br>
![изображение](https://user-images.githubusercontent.com/86486142/176212773-4d5aa0b8-2703-44cb-bc14-9e58c3cf47d4.png)

---

## Тестовые данные метода
В качестве примера возьмем следующий тестовые данные:
<table>
<tr>
<th>Требование</th>
<th>	Промежуток времени</th>
<th>Результат</th>
</tr>
<tr>
<td>Начало консультации в 10:00</td>
<td>09:30 – 10:00</td>
<td>True</td>
</tr>
<tr>
<td></td>
<td>11:30 – 12:00</td>
<td>False</td>
</tr>
</table>

Если клиент таки успевает на консультацию в 10:00, то тест прошел успешно и выводится True<br>
В противном случае выводится False

## Тестовый сценарий
![изображение](https://user-images.githubusercontent.com/86486142/177056991-8f2f989b-7bdc-4c9c-9ea6-115305a2a792.png)

## Скриншот выполнения программы
![изображение](https://user-images.githubusercontent.com/86486142/177056868-77da9562-1d08-426e-843e-597225de723b.png)

