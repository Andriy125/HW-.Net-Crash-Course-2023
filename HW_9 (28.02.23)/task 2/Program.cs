// Створюємо об'єкт телефону
using HW_9__28._02._23__task_2;

Phone phone = new Phone();
phone.Model = "Samsung Galaxy S21";
phone.Size = 6.2;
phone.Weight = 169;
phone.BatteryCapacity = 4000;
phone.ScreenSize = 6.2;
phone.CameraCount = 3;
phone.OS = "Android 11";

// Додаємо контакт
phone.AddContact("John Smith", "+380501234567");

// Надсилаємо повідомлення
phone.SendSMS("+380501234567", "Привіт, як справи?");

// Створюємо об'єкт смарт-годинника
Smartwatch smartwatch = new Smartwatch();
smartwatch.Model = "Apple Watch Series 6";
smartwatch.Size = 44;
smartwatch.Weight = 47.1;
smartwatch.BatteryCapacity = 1500;
smartwatch.ScreenSize = 1.78;
smartwatch.Sensors = new string[] { "Accelerometer", "Gyroscope", "Heart rate sensor" };
smartwatch.OS = "watchOS 7";

// Додаємо контакт
smartwatch.AddContact("Jane Doe", "+380501112233");

// Надсилаємо повідомлення
smartwatch.SendSMS("+380501112233", "Привіт, як справи?");

// Отримуємо геолокацію
string location = smartwatch.GetLocation();

// Виводимо геолокацію на карті
smartwatch.ShowOnMap(location);

// Створюємо об'єкт планшета
Tablet tablet = new Tablet();
tablet.Model = "iPad Air (4th generation)";
tablet.Size = 10.9;
tablet.Weight = 460;
tablet.BatteryCapacity = 6000;
tablet.ScreenSize = 10.9;
tablet.Memory = 256;
tablet.Sensors = new string[] { "Touch ID", "Three-axis gyro", "Accelerometer", "Barometer" };
tablet.OS = "iPadOS 14";

// Отримуємо геолокацію
location = tablet.GetLocation();

// Виводимо геолокацію на карті
tablet.ShowOnMap(location);

// Відтворюємо медіа
tablet.playMedia("song.mp3");

// Зупиняємо медіа
tablet.stopMedia();