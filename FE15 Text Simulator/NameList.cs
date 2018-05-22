﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE15TextSimulator
{
    public class NameList
    {
        //Holds English names and their corresponding Japanese name used on their portrait file
        public SortedDictionary<string, string> Names = new SortedDictionary<string, string>()
        {
            //Playable Characters
            {"Alm", "アルム"},
            {"Alm (Child)", "幼少アルム"},
            {"Alm (Hero)", "アルム上級"},
            {"Lukas", "ルカ"},
            {"Gray", "グレイ"},
            {"Gray (Child)", "幼少グレイ"},
            {"Tobin", "ロビン"},
            {"Tobin (Child)", "幼少ロビン"},
            {"Faye", "エフィ"},
            {"Faye (Child)", "幼少エフィ"},
            {"Kliff", "クリフ"},
            {"Kliff (Child)", "幼少クリフ"},
            {"Silque", "シルク"},
            {"Clair", "クレア"},
            {"Clive", "クレーベ"},
            {"Forsyth", "フォルス"},
            {"Python", "パイソン"},
            {"Celica", "セリカ"},
            {"Celica (Child)", "幼少セリカ"},
            {"Celica (Princess)", "セリカ上級"},
            {"Boey", "ボーイ"},
            {"Mae", "メイ"},
            {"Genny", "ジェニー"},
            {"Saber", "セーバー"},
            {"Valbar", "バルボ"},
            {"Kamui", "カムイ"},
            {"Leon", "レオ"},
            {"Luthier", "リュート"},
            {"Mathilda", "マチルダ"},
            {"Delthea", "デューテ"},
            {"Palla", "パオラ"},
            {"Catria", "カチュア"},
            {"Atlas", "アトラス"},
            {"Jesse", "ジェシー"},
            {"Sonya", "ソニア"},
            {"Deen", "ディーン"},
            {"Est", "エスト"},
            {"Nomah", "ノーマ"},
            {"Tatiana", "ティータ"},
            {"Zeke", "ジーク"},
            {"Conrad", "コンラート"},
            {"Conrad (Masked)", "仮面の騎士"},
            {"Mycen", "マイセン"},

            //Amiibo
            {"Marth", "マルス"},
            {"Ike", "アイク"},
            {"Robin", "ルフレ男"},
            {"Lucina", "ルキナ"},
            {"Roy", "ロイ"},
            {"Corrin (Male)", "カムイ男"},
            {"Corrin (Female)", "カムイ女"},

            //Enemies
            {"Wolff", "ウォルフ"},
            {"Gazelle", "ガゼル"},
            {"Garth", "ガッハ"},
            {"Gharn", "ガネフ"},
            {"Garcia", "ガルシア"},
            {"Greith", "ギース"},
            {"Cerberus", "ケルベス"},
            {"Aurum", "ゴールド"},
            {"Xaizor", "サイゾー"},
            {"Zakson", "ザクソン"},
            {"Jerome", "ジェローム"},
            {"Jamil", "ジャミル"},
            {"Jedah", "ジュダ"},
            {"Argentum", "シルバー"},
            {"Slayde", "スレイダー"},
            {"Tatarrah", "タタラ"},
            {"Barth", "ダッハ"},
            {"Desaix", "ドゼー"},
            {"Dolk", "ドルク"},
            {"Nuibaba", "ヌイババ"},
            {"Hades", "バデス"},
            {"Fernand", "フェルナン"},
            {"Blake", "ブライ"},
            {"Hestia", "ヘステ"},
            {"Berkut", "ベルクト"},
            {"Naberius", "ベルレス"},
            {"Marla", "マーラ"},
            {"Magnus", "マグナム"},
            {"Mikhail", "ミカエラ"},
            {"Mueller", "ミューラー"},
            {"Rudolf", "ルドルフ"},
            {"Lawson", "ローソン"},
            {"Berkut (Posessed)", "異常ベルクト"},
            {"Brigand Boss", "盗賊頭"},
            {"Rinea (Witch)", "魔女リネア"},

            //NPCs
            {"Irma", "イルマ"},
            {"Fat Merchant", "でっぷり商人"},
            {"Duma", "ドーマ"},
            {"Duma (Human)", "ドーマ人間形態"},
            {"Halcyon", "ハルク"},
            {"Massena", "マッセナ"},
            {"Mila", "ミラ"},
            {"Rinea", "リネア"},
            {"Old Man", "一般おじいさん"},
            {"Man", "一般おじさん"},
            {"Young Man", "一般おにいさん"},
            {"Young Woman", "一般おねえさん"},
            {"Woman", "一般おばさん"},
            {"Celica (Fake)", "偽セリカ"},
            {"Peddler (Pink)", "商人桃"},
            {"Peddler (Green)", "商人緑"},
            {"Peddler (Blue)", "商人青"},
            {"Girl", "女の子"},
            {"Scholarly Man", "学者風の男"},
            {"Conrad (Child)", "幼少コンラート"},
            {"Flashy Man", "派手な服の男"},
            {"Brigand B", "盗賊B"},
            {"Saint", "聖女"},
            {"Nobleman", "貴族のおじさん"},
            {"Nobleman B", "貴族のおじさんB"},
            {"Aristocratic Man", "貴族の老人"},
            {"Blacksmith", "鍛冶屋"},
            {"Hermit", "隠者"},

            //Classes
            {"Archer", "アーチャー"},
            {"Archer (Blue)", "アーチャー青"},
            {"Knight", "アーマー"},
            {"Gold Knight", "ゴールドナイト"},
            {"Gold Knight (Female)", "ゴールドナイト女"},
            {"Cleric", "シスター"},
            {"Cleric (Blue)", "シスター青"},
            {"Sniper", "スナイパー"},
            {"Soldier", "ソルジャー"},
            {"Soldier (Blue)", "ソルジャー青"},
            {"Cavalier", "ナイト"},
            {"Cavalier (Female)", "ナイト女"},
            {"Cavalier (Blue)", "ナイト青"},
            {"Paladin", "パラディン"},
            {"Paladin (Female)", "パラディン女"},
            {"Baron ", "バロン"},
            {"Falcon Knight", "ファルコンナイト"},
            {"Pegasus Knight", "ペガサスナイト"},
            {"Bow Knight", "ボウナイト"},
            {"Mercenary", "傭兵"},
            {"Mercenary (Blue) ", "傭兵青"},
            {"Myrmidon", "剣士"},
            {"Arcanist", "妖術師"},
            {"Villager (Female)", "村人女"},
            {"Villager (Male)", "村人男"},
            {"Brigand", "盗賊"},
            {"Cantor", "祈祷師"},
            {"Priestess", "神官赤"},
            {"Priestess (Blue)", "神官"},
            {"Sage (Blue)", "賢者青"},

            //Monsters
            {"Vesta", "ウェスタ"},
            {"Gargoyle", "ガーゴイル"},
            {"Garuda", "ガルーダ"},
            {"Bonewalker", "スケルトン"},
            {"Revenant", "ゾンビ"},
            {"Titan", "タイタン"},
            {"Dagon", "ダゴン"},
            {"Deimos", "デイモス"},
            {"Duma's Apostle", "ドーマの使徒"},
            {"Dracul", "ドラクル"},
            {"Necrodragon", "ドラゴンゾンビ"},
            {"Deathgoyle", "バルログ"},
            {"Valor", "バロール"},
            {"Mogall", "ビグル"},
            {"Fafnir", "ファフナー"},
            {"Entombed", "マミー"},
            {"Mila's Servant", "ミラのしもべ"},
            {"Lich", "リッチー"},
            {"Guardian", "守護者"},
            {"Fire Dragon", "火竜"},
            {"White Dragon", "白竜"},
            {"The Creation", "造られしもの"},

            //Other
            {"Shadow Man", "_カゲマン"},

            //DLC
            {"Emma", "エマ"},
            {"Randal", "ランド"},
            {"Shade", "シェイド"},
            {"Yuzu", "ユズ"},
            {"Clive (DLC)", "クレーベ2"},
            {"Mathilda (DLC)", "マチルダ2"},
            {"Hostages", "リゲル人捕虜"},
            {"Tomb Lord", "キングマミー"},
        };

        private List<string> playable = new List<string>()
        {
            "Alm",
            "Alm (Child)",
            "Alm (Hero)",
            "Atlas",
            "Boey",
            "Catria",
            "Celica",
            "Celica (Child)",
            "Celica (Princess)",
            "Clair",
            "Clive",
            "Conrad",
            "Conrad (Masked)",
            "Corrin (Female)",
            "Corrin (Male)",
            "Deen",
            "Delthea",
            "Est",
            "Faye",
            "Faye (Child)",
            "Forsyth",
            "Genny",
            "Gray",
            "Gray (Child)",
            "Ike",
            "Jesse",
            "Kamui",
            "Kliff",
            "Kliff (Child)",
            "Leon",
            "Lucina",
            "Lukas",
            "Luthier",
            "Mae",
            "Marth",
            "Mathilda",
            "Mycen",
            "Nomah",
            "Palla",
            "Python",
            "Robin",
            "Roy",
            "Saber",
            "Silque",
            "Sonya",
            "Tatiana",
            "Tobin",
            "Tobin (Child)",
            "Valbar",
            "Zeke",

            "Emma",
            "Randal",
            "Shade",
            "Yuzu",
            "Clive (DLC)",
            "Mathilda (DLC)"
        };

        public List<string> GetPlayable()
        {
            return playable;
        }

        public Dictionary<string, string> Expressions = new Dictionary<string, string>()
        {
            {"Normal", "通常"},
            {"Cool", "キメ"},
            {"Anger", "怒"},
            {"Sadness", "悲"},
            {"Smile", "笑"},
            {"Pain", "苦"},
            {"Surprised", "驚"},
            {"Special", "特殊1"},
            {"Posessed", "幽霊"},
        };

        private List<string> backgrounds = new List<string>()
        {
            "Altar of Duma",
            "Dolth Keep",
            "Duma Temple",
            "Duma",
            "Dungeon",
            "Forest Crossroads",
            "Forest Village",
            "Furia Harbor Entrance",
            "Furia Harbor Square",
            "Mila Shrine",
            "Mila Temple Exterior",
            "Mycen's House",
            "Novis Greatport",
            "Pirate Throne Interior",
            "Plains 1",
            "Plains 2",
            "Plains 3",
            "Priory",
            "Prison 1",
            "Prison 2",
            "Ram Valley",
            "Ram Village Entrance",
            "Ram Village Flower Patch",
            "Ram Village Ourskirts",
            "Sage's Hamlet",
            "Ship 1",
            "Ship 2",
            "Sluice Gate Interior",
            "Sluice Gate",
            "Swamp",
            "Thabes Labyrinth",
            "Villa",
            "War Room",
            "Zofia Castle Balcony",
            "Zofia Castle Exterior",
            "Zofia Castle Interior",
            "Zofian Coast",
        };

        public List<string> GetBackgrounds()
        {
            return backgrounds;
        }
    }
}
