using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<PoolLevel> Levels;
    public PoolLevel currentLevel;


    public int totalLevelCount;
    public int levelLoopFrom;
    
    void Awake() => Initialize();
    void Initialize(){
        ConstructLevel();
    }
    private void ConstructLevel(){
        foreach (var item in Levels)
        {
            PoolLevel level = Instantiate(item);
            level.Deactiavte();
        }
        GetLevel(DataManager.Instance.Level);
    }

    [ContextMenu("GetLevel")]
    PoolLevel GetLevel(int currentLevel){
        if(currentLevel > totalLevelCount){
            int levelindex = Levels.IndexOf(Levels[currentLevel]) % totalLevelCount;
            PoolLevel level = Levels[levelindex];
            level.Activate();
            return level; 
        }else{
            PoolLevel level = Levels[currentLevel];
            level.Activate();
            return level;
        }
       
    }

    void OnSuccesLevel(){

    }
    void OnFailLevel(){

    }
    

}
