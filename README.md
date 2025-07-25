# Проектирование и разработка программного обеспечения автоматизированной информационной системы «Управление медицинскими записями пациентов»

## Описание проекта

Данный проект представляет собой разработку автоматизированной информационной системы (ИС) для управления медицинскими записями пациентов в ГБУЗ «Лабинская центральная районная больница». Система предназначена для автоматизации процессов ведения медицинских записей, улучшения качества обслуживания пациентов и повышения эффективности работы медицинского персонала.

### Основные функции системы:

- Централизованное хранение медицинских записей пациентов.
- Удобный поиск и доступ к медицинским данным.
- Возможность добавления, редактирования и удаления записей.
- Разграничение прав доступа для разных типов пользователей (гость, врач, администратор).
- Управление отделениями больницы.

## Технологии и инструменты

- **Язык программирования**: C#
- **Среда разработки**: Visual Studio
- **Система управления базами данных (СУБД)**: PostgreSQL
- **Библиотека для работы с БД**: Npgsql (ADO.NET для PostgreSQL)
- **Диаграммы и модели**: UML (диаграммы деятельности, вариантов использования, ER-диаграммы)

## Структура проекта

Проект состоит из следующих основных модулей:

1. **Главная форма**: Навигация по системе, вход и регистрация пользователей.
2. **Форма отображения записей**: Просмотр всех записей пациентов, поиск по данным.
3. **Форма добавления записей**: Создание новых записей пациентов.
4. **Форма редактирования записей**: Редактирование и удаление записей.
5. **Форма личного кабинета**: Управление данными пользователя и статистика записей.
6. **Форма администратора**: Управление пользователями и отделениями больницы.

## Установка и запуск

### Требования:

- Установленная СУБД PostgreSQL.
- Установленная среда разработки Visual Studio.
- Библиотека Npgsql для работы с PostgreSQL.

### Шаги для запуска:

1. Клонируйте репозиторий:
2. Откройте проект в Visual Studio.
3. Настройте подключение к базе данных PostgreSQL, указав параметры в файле конфигурации.
4. Запустите проект через Visual Studio.

## Руководство пользователя

1. **Вход в систему**:
   - Перейдите на форму входа и введите логин и пароль.
   - Нажмите кнопку «Вход».
2. **Просмотр записей**:
   - На главной форме выберите вкладку «Все записи» или «Записи отдела» для просмотра записей.
3. **Добавление записей**:
   - Перейдите во вкладку «Добавить запись», введите данные пациента и нажмите «Добавить».
4. **Редактирование и удаление записей**:
   - Перейдите во вкладку «Мои записи», выберите запись и нажмите «Редактировать» или «Удалить».
5. **Управление отделениями (для администратора)**:
   - Перейдите во вкладку «Отделения» для добавления, редактирования или удаления отделений.
6. **Выход из системы**:
   - Нажмите кнопку «Выход» для завершения работы с системой.

## Заключение

Разработанная система управления медицинскими записями пациентов позволяет эффективно управлять медицинскими данными, улучшает качество обслуживания пациентов и повышает производительность работы медицинского персонала. Система может быть адаптирована для использования в других медицинских учреждениях.

## Список использованных источников

1. Npgsql - .NET Access to PostgreSQL. [Ссылка](https://www.npgsql.org/)
2. PostgreSQL Documentation. [Ссылка](https://www.postgresql.org/docs/)
3. Visual Studio Documentation. [Ссылка](https://docs.microsoft.com/ru-ru/visualstudio/)
4. UML диаграммы. [Ссылка](https://www.uml-diagrams.org/)

---

## Картинки

<div style="text-align: center;">

![Game Screenshot](./assets/all-records.png)

![Game Screenshot](./assets/all-users.png)

![Game Screenshot](./assets/department-records.png)

![Game Screenshot](./assets/my-records.png)

![Game Screenshot](./assets/sign-in.png)

</div>

---

**Автор**: Федоренко Андрей Юрьевич  
**Руководитель**: Ефентьева Ирина Петровна  
**Год**: 2024  
**Организация**: ГАПОУ КК ЛАТ, Лабинск
