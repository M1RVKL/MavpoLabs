[![](https://img.plantuml.biz/plantuml/svg/ZLJ1ReCm3BtdAtmiX_x03bFPj9qsgIfgTvoYO3gh8PcIqAr_lq13Ie1svORVix7zdbbPnurhQicuSDh0rg81Rc4RtWl7gweD526mbjnLHflwavSrgHRA6UlIbij7M1J8ZVW2BeIkQrroHrhPR41uqle0Hkjw67pd1uGrFzMeN9PKaoWS-FSZ2Kpgx0X_kZfGekCa4_33a4CmUFIaQL8NJlWRt9DrxUY-xoRjuKtlWLJQhU9xXCRE9tJ3V4-78KMEUDTNrQWoOom_0yzQLMJgIqw8hutsGzl8pvFFRx1TIxVW2wHBD3oERYEmGqFLQI8BAvAI-H06__cA96OzgLz4SMrdQR6DryQEWqLKikWLTlv394ZjOooe5CTh6qsbk-KrU82NNuUgj6pnIhBjqDTgfBi_RUgjUpClxfunjYTwDx1-aUDxc8KdMvvb9Nu_Cm3ORLaJKVkgmIVvQCB_JT8N62yWN73KVRYi6IE7W-1Ae8p06RahCLnIWao47JehpJDfNZVHvAQkhfoDBtR-xdlo-End_Xw1sZuhFq7xd_u3)](https://editor.plantuml.com/uml/ZLJ1ReCm3BtdAtmiX_x03bFPj9qsgIfgTvoYO3gh8PcIqAr_lq13Ie1svORVix7zdbbPnurhQicuSDh0rg81Rc4RtWl7gweD526mbjnLHflwavSrgHRA6UlIbij7M1J8ZVW2BeIkQrroHrhPR41uqle0Hkjw67pd1uGrFzMeN9PKaoWS-FSZ2Kpgx0X_kZfGekCa4_33a4CmUFIaQL8NJlWRt9DrxUY-xoRjuKtlWLJQhU9xXCRE9tJ3V4-78KMEUDTNrQWoOom_0yzQLMJgIqw8hutsGzl8pvFFRx1TIxVW2wHBD3oERYEmGqFLQI8BAvAI-H06__cA96OzgLz4SMrdQR6DryQEWqLKikWLTlv394ZjOooe5CTh6qsbk-KrU82NNuUgj6pnIhBjqDTgfBi_RUgjUpClxfunjYTwDx1-aUDxc8KdMvvb9Nu_Cm3ORLaJKVkgmIVvQCB_JT8N62yWN73KVRYi6IE7W-1Ae8p06RahCLnIWao47JehpJDfNZVHvAQkhfoDBtR-xdlo-End_Xw1sZuhFq7xd_u3)

Use Cases
-
UC1  Search Accommodations

UC2  Filter Results

UC3  View Reviews

UC4  View Room Details

UC5  Book Room

UC6  Select Services

UC7  Write Review

UC8  Register Account

UC9  Log In

UC10  Manage User Account

UC11  Make Payment

UC12  Initiate Refund

UC13  Manage Rooms

UC14  Manage Services

UC15  Set Pricing

UC16  View Reservations

UC17  Manage Accommodation Profile

UC18  Moderate Reviews

UC19  Confirm Payment

UC20  Process Refund

UC21  Verify Accommodations

UC22  Manage Reservation

UC23  Confirm Reservation

UC24  Cancel Reservation


Requirements
---------------------------
* Functional
  
FR1  Користувач повинен мати змогу знаходити та фільтрувати житло.

FR2  Користувач повинен мати змогу переглядати детальну інформацію про житло (деталі номера, відгуки).

FR3  Користувач повинен мати змогу забронювати номер, обравши додаткові послуги.

FR4  Користувач повинен мати змогу ініціювати повернення коштів.

FR5  Система повинна підтримувати повний життєвий цикл акаунта Користувача (реєстрація, вхід, керування).

FR6  Персонал повинен мати змогу змінювати статус доступності кімнат (номер недоступний через ремонт, тощо).

FR7  Адміністратори повинні мати змогу адмініструвати бронювання (підтверджувати, скасовувати).

FR8  Персонал повинен мати змогу переглядати бронювання та їх статус

FR8  Система повинна забезпечувати процес управління відгуками (створення Користувачем та модерація Адміністратором).

FR9  Адміністратор повинен мати інструменти контролю платформи (верифікація готелів, обробка повернень).

FR10  Система повинна забезпечувати повний цикл фінансових операціій, включаючи встановлення цін персоналом, підтвердження статусу оплати адміністратором та обробку повернень.

FR11: Користувач повинен здійснити оплату бронювання для його фінального підтвердження.

FR12: Персонал повинен мати змогу створювати, редагувати та видаляти список додаткових послуг (наприклад: сніданок, прибирання), доступних для бронювання.

FR13: Персонал повинен мати змогу створювати та редагувати профіль свого готелю (наприклад: завантажувати фото, додавати опис, вказувати адресу).

* Non-functional
  
NFR1 (Usability) Інтерфейс має бути інтуїтивно зрозумілим для всіх трьох ролей (User, Staff, Admin).
  
NFR2 (Performance)  Час відповіді сервера на API-запити, що не пов'язані з пошуком (наприклад, Log In, View Room Details), не повинен перевищувати 800 мілісекунд.
  
NFR3 (Compatibility) 

Матриця трасування:

| FR/UC | UC1 | UC2 | UC3 | UC4 | UC5 | UC6 | UC7 | UC8 | UC9 | UC10 | UC11 | UC12 | UC13 | UC14 | UC15 | UC16 | UC17 | UC18 | UC19 | UC20 | UC21 | UC22 | UC23 | UC24 |
| :--- | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| **FR1** | X | X | | | | | | X | X | | | | | | | | | | | | X | | | |
| **FR2** | | | X | X | | | | X | X | | | | X | | X | | X | | | | X | | | |
| **FR3** | | | | | X | X | | X | X | | X | | | | X | | | | X | | X | | X | |
| **FR4** | | | | | X | | | X | X | | X | X | | | | | | | | X | | | | |
| **FR5** | | | | | | | | X | X | X | | | | | | | | | | | | | | |
| **FR6** | | | | | | | | X | X | | | | X | | | | X | | | | X | X | | |
| **FR7** | | | | | | | | | | | | | | | | | | | | | | X | X | X |
| **FR8**| | | | | | | X | | | | | | | | | X | | X | | | | | | |
| **FR9** | | | | | | | | | | | | | | | | | | | | X | X | | | |
| **FR10** | | | | | | | | | | | | | | | X | | | | X | X | | | | |
| **FR11**| | | | | | | | | | | X | | | | | | | | | | | | | |
| **FR12**| | | | | | | | | | | | | | X | | | | | | | | | | |
| **FR13**| | | | | | | | | | | | | | | | | X | | | | | | | |
