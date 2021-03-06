# Принцип инверсии зависимостей
Простое эвристическое правило — зависеть нужно от абстракций — на деле оказа-
лось более сложным, чем могло показаться изначально.
Принцип инверсии зависимостей не сводится лишь к выделению интерфейсов
и передаче их через конструктор. DIP объясняет, для чего нужно это делать. Клас-
сы имеют право контролировать свои детали реализации, но некоторые аспекты
находятся за пределами их компетенции. Чтобы не завязываться на классы верх-
него уровня, класс может объявить некоторый интерфейс и потребовать его экзем-
пляр через аргументы конструктора. Таким образом мы можем инвертировать
зависимости и позволить классам нижних уровней взаимодействовать с другими
частями системы, ничего конкретного о них не зная.