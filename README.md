# 🍉 FruitCutMaster

Mobil platformlar için geliştirilen, Cut the Rope tarzında fizik tabanlı bir ip kesme oyunudur.  
Oyuncular, ipleri keserek karpuzları hedefe düşürmeye çalışır.

---

## 🎮 Özellikler

- Rope Physics sistemi (DistanceJoint2D)
- Cut Effect + Ses efektleri
- Ana Menü ve Level Seçimi
- Karpuz temalı görseller ve arka planlar
- Ses: cut, click, win, yumm, fail

---

## 🔧 Kurulum

1. Unity Hub üzerinden `Unity 6000.1.8f1` sürümünü indir
2. Bu repoyu klonla veya indir
3. Unity Hub > Open > `FruitCutMaster` klasörünü seç
4. Build Settings'ten Android veya iOS platformunu seç
5. `Scenes in Build` listesine şunları ekle:
   - `Assets/Scenes/MainMenu.unity`
   - `Assets/Scenes/LevelSelect.unity`
   - `Assets/Scenes/Level1.unity`
6. `Build` butonuna tıkla → .apk veya iOS dosyası çıkar

---

## 📁 Klasör Yapısı

Assets/
├── Scripts/
│ ├── AudioManager.cs
│ ├── MainMenuManager.cs
│ ├── LevelSelectManager.cs
│ ├── LevelButton.cs
│ ├── RopeCutter.cs
│ └── RopeGenerator.cs
├── Scenes/
├── Audio/
├── Prefabs/
└── Sprites/

---

## 📱 Platformlar

- Android (tested)
- iOS (Xcode required)

---

## 👤 Geliştirici

Bu proje [@atonegtx](https://github.com/atonegtx) tarafından geliştirilmiştir  
Kodlama ve proje desteği: ChatGPT 🤖👑
