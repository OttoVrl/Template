using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<PoolLevel> Levels;
    public List<PoolLevel> CreatedLevels;
    public PoolLevel currentLevelObject;


    public int totalLevelCount;
    public int levelLoopFrom;

    void Start() => Initialize();

    void Initialize()
    {
        ConstructLevel();
    }

    private void ConstructLevel()
    {
        foreach (var item in Levels)
        {
            PoolLevel level = Instantiate(item.gameObject).GetComponent<PoolLevel>();
            CreatedLevels.Add(level);
            level.Deactiavte();
        }
        // currentLevelObject = GetLevel(DataManager.Instance.Level);
        GetLevel(DataManager.Instance.Level);
    }

    private void Update()
    {
        print(DataManager.Instance.Level);
    }


    PoolLevel GetLevel(int currentLevel)
    {
        foreach (var item in CreatedLevels)
        {
            item.Deactiavte();
        }

        if (currentLevel > totalLevelCount - 1)
        {
            int levelindex = CreatedLevels.IndexOf(CreatedLevels[currentLevel % totalLevelCount]);
            PoolLevel level = CreatedLevels[levelindex];
            level.Activate();
            return level;
        }
        else
        {
            PoolLevel level = CreatedLevels[currentLevel];
            level.Activate();
            return level;
        }
    }

    
    [ContextMenu(nameof(SetLevel))]
    int SetLevel()
    {
        DataManager.Instance.Level++;
        currentLevelObject = GetLevel(DataManager.Instance.Level);
        return DataManager.Instance.Level;
    }

    void OnSuccesLevel()
    {
    }

    void OnFailLevel()
    {
    }
}