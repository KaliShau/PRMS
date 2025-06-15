-- CreateTable
CREATE TABLE "User" (
    "id" SERIAL NOT NULL,
    "created_at" TIMESTAMP(3) NOT NULL DEFAULT CURRENT_TIMESTAMP,
    "FIO" TEXT NOT NULL,
    "email" TEXT NOT NULL,
    "password" TEXT NOT NULL,
    "isAdmin" BOOLEAN NOT NULL DEFAULT false,
    "departmentId" INTEGER,

    CONSTRAINT "User_pkey" PRIMARY KEY ("id")
);

-- CreateTable
CREATE TABLE "Patient" (
    "id" SERIAL NOT NULL,
    "created_at" TIMESTAMP(3) NOT NULL DEFAULT CURRENT_TIMESTAMP,
    "FIO" TEXT NOT NULL,
    "record_type" TEXT NOT NULL,
    "address" TEXT NOT NULL,
    "content" TEXT NOT NULL,
    "userId" INTEGER,
    "departmentId" INTEGER,

    CONSTRAINT "Patient_pkey" PRIMARY KEY ("id")
);

-- CreateTable
CREATE TABLE "Department" (
    "id" SERIAL NOT NULL,
    "created_at" TIMESTAMP(3) NOT NULL DEFAULT CURRENT_TIMESTAMP,
    "name" TEXT NOT NULL,

    CONSTRAINT "Department_pkey" PRIMARY KEY ("id")
);

-- CreateIndex
CREATE UNIQUE INDEX "User_email_key" ON "User"("email");

-- CreateIndex
CREATE UNIQUE INDEX "Department_name_key" ON "Department"("name");

-- AddForeignKey
ALTER TABLE "User" ADD CONSTRAINT "User_departmentId_fkey" FOREIGN KEY ("departmentId") REFERENCES "Department"("id") ON DELETE SET NULL ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE "Patient" ADD CONSTRAINT "Patient_userId_fkey" FOREIGN KEY ("userId") REFERENCES "User"("id") ON DELETE SET NULL ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE "Patient" ADD CONSTRAINT "Patient_departmentId_fkey" FOREIGN KEY ("departmentId") REFERENCES "Department"("id") ON DELETE SET NULL ON UPDATE CASCADE;

INSERT INTO "Department" ("name") VALUES 
('Терапевтическое отделение'),
('Хирургическое отделение'),
('Неврологическое отделение'),
('Кардиологическое отделение'),
('Офтальмологическое отделение'),
('Оториноларингологическое отделение'),
('Гинекологическое отделение'),
('Педиатрическое отделение'),
('Реанимационное отделение'),
('Инфекционное отделение'),
('Травматологическое отделение'),
('Онкологическое отделение');

INSERT INTO "User" ("FIO", "email", "password", "isAdmin", "departmentId") VALUES 
('Иванов Иван Иванович', 'q', 'q', true, 1),
('Петров Петр Петрович', 'petrov@example.com', 'password123', false, 2),
('Сидорова Анна Михайловна', 'sidorova@example.com', 'password123', false, 3),
('Кузнецов Дмитрий Сергеевич', 'kuznetsov@example.com', 'password123', false, 4),
('Смирнова Елена Владимировна', 'smirnova@example.com', 'password123', false, 5),
('Васильев Андрей Николаевич', 'vasiliev@example.com', 'password123', false, 6),
('Павлова Ольга Игоревна', 'pavlova@example.com', 'password123', false, 7),
('Николаев Сергей Александрович', 'nikolaev@example.com', 'password123', false, 8),
('Федорова Марина Викторовна', 'fedorova@example.com', 'password123', false, 9),
('Алексеев Алексей Алексеевич', 'alekseev@example.com', 'password123', false, 10),
('Григорьева Татьяна Дмитриевна', 'grigorieva@example.com', 'password123', false, 11),
('Борисов Борис Борисович', 'borisov@example.com', 'password123', false, 12);

INSERT INTO "Patient" ("FIO", "record_type", "address", "content", "userId", "departmentId") VALUES 
('Семенов Артем Валерьевич', 'Первичный прием', 'ул. Ленина, 15, кв. 34', 'Жалобы на головную боль и повышенную температуру', 1, 1),
('Ковалева Ирина Сергеевна', 'Повторный прием', 'ул. Гагарина, 42, кв. 12', 'Контроль после перенесенной операции', 2, 2),
('Михайлов Денис Олегович', 'Экстренная госпитализация', 'пр. Мира, 89, кв. 67', 'Острая боль в пояснице', 3, 3),
('Орлова Виктория Андреевна', 'Плановый осмотр', 'ул. Кирова, 5, кв. 23', 'Профилактический осмотр', 4, 4),
('Жуков Станислав Игоревич', 'Первичный прием', 'ул. Пушкина, 17, кв. 45', 'Ухудшение зрения', 5, 5),
('Савельева Анастасия Павловна', 'Повторный прием', 'ул. Советская, 33, кв. 78', 'Контроль лечения хронического заболевания', 6, 6),
('Тимофеев Геннадий Васильевич', 'Экстренная госпитализация', 'ул. Маяковского, 12, кв. 9', 'Острая боль в животе', 7, 7),
('Маркова Елизавета Денисовна', 'Плановый осмотр', 'ул. Чехова, 56, кв. 32', 'Профилактический осмотр ребенка', 8, 8),
('Белов Александр Николаевич', 'Первичный прием', 'ул. Горького, 78, кв. 11', 'Травма после падения', 9, 9),
('Крылова Ольга Викторовна', 'Повторный прием', 'ул. Лермонтова, 23, кв. 45', 'Контроль после инфекционного заболевания', 10, 10),
('Громов Павел Сергеевич', 'Экстренная госпитализация', 'ул. Толстого, 67, кв. 89', 'Перелом руки', 11, 11),
('Зайцева Мария Александровна', 'Плановый осмотр', 'ул. Достоевского, 34, кв. 56', 'Профилактический осмотр', 12, 12),
('Фролов Игорь Владимирович', 'Первичный прием', 'ул. Некрасова, 45, кв. 23', 'Жалобы на боли в сердце', 4, 4),
('Антонова Светлана Игоревна', 'Повторный прием', 'ул. Тургенева, 67, кв. 12', 'Контроль артериального давления', 1, 1),
('Данилов Артем Викторович', 'Экстренная госпитализация', 'ул. Белинского, 89, кв. 34', 'Острое нарушение мозгового кровообращения', 3, 3),
('Егорова Наталья Сергеевна', 'Плановый осмотр', 'ул. Герцена, 12, кв. 56', 'Профилактический осмотр', 5, 5),
('Сорокин Вадим Олегович', 'Первичный прием', 'ул. Чернышевского, 34, кв. 78', 'Жалобы на боли в ухе', 6, 6),
('Ларина Екатерина Андреевна', 'Повторный прием', 'ул. Добролюбова, 56, кв. 90', 'Контроль после гинекологической операции', 7, 7),
('Мельников Дмитрий Игоревич', 'Экстренная госпитализация', 'ул. Островского, 78, кв. 12', 'Высокая температура у ребенка', 8, 8),
('Романова Анна Владимировна', 'Плановый осмотр', 'ул. Гончарова, 90, кв. 34', 'Профилактический осмотр', 9, 9);