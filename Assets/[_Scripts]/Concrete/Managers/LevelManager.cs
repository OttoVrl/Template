using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int levelCount;
    public int levelLoopFrom;
    private void Start() => ConstructLevel();

    private void ConstructLevel()
    {
        int _level = DataManager.Instance.Level;
        while (_level > DataManager.Instance.Level)
            _level = _level - levelCount + (levelLoopFrom - 1);
        // Instantiate(Resources.Load<GameObject>("Levels/Level-" + _level));
    }

    public int LevelUp(int currentLevel)
    {
        DataManager.Instance.Level++;
        return DataManager.Instance.Level;
    }

    public void OnSucceed()
    {
        
    }

    public void OnFail()
    {
        
    }


    #region Bizim yöntem

    // public List<PoolLevel> Levels;
    // public List<PoolLevel> CreatedLevels;
    //
    //
    // public int totalLevelCount;
    // public int levelLoopFrom;
    //
    // void Awake() => Initialize();
    //
    // void Initialize()
    // {
    //     ConstructLevel();
    // }
    //
    // private void ConstructLevel()
    // {
    //     foreach (var item in Levels)
    //     {
    //         PoolLevel level = Instantiate(item.gameObject).GetComponent<PoolLevel>();
    //         level.gameObject.transform.SetParent(this.transform);
    //         CreatedLevels.Add(level);
    //         level.Deactiavte();
    //     }
    //     GetLevel(DataManager.Instance.Level);
    // }
    //
    // private void Update()
    // {
    //     print(DataManager.Instance.Level);
    // }
    //
    //
    // PoolLevel GetLevel(int currentLevel)
    // {
    //     foreach (var item in CreatedLevels)
    //     {
    //         item.Deactiavte();
    //     }
    //
    //     if (currentLevel > totalLevelCount - 1)
    //     {
    //         int levelindex = CreatedLevels.IndexOf(CreatedLevels[currentLevel % totalLevelCount]);
    //         PoolLevel level = CreatedLevels[levelindex];
    //         level.Activate();
    //         return level;
    //     }
    //     else
    //     {
    //         PoolLevel level = CreatedLevels[currentLevel];
    //         level.Activate();
    //         return level;
    //     }
    // }
    //
    //
    // [ContextMenu(nameof(SetLevel))]
    // int SetLevel()
    // {
    //     DataManager.Instance.Level++;
    //     GetLevel(DataManager.Instance.Level);
    //     return DataManager.Instance.Level;
    // }
    //
    // int LevelUp()
    // {
    //     DataManager.Instance.Level++;
    //     return DataManager.Instance.Level;
    // }
    //
    // void OnSuccesLevel()
    // {
    // }
    //
    // void OnFailLevel()
    // {
    // }

    #endregion
}