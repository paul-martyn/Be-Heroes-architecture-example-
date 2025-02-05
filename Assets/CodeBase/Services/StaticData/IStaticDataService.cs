﻿using CodeBase.StaticData;
using CodeBase.StaticData.Windows;
using CodeBase.UI.Services.Windows;

namespace CodeBase.Services.StaticData
{
    public interface IStaticDataService : IService
    {
        void Load();
        HeroStaticData ForHero();
        MonsterStaticData ForMonster(MonsterTypeId typeId);
        LevelStaticData ForLevel(string sceneKey);
        WindowConfig ForWindow(WindowId windowId);
    }
}