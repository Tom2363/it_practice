using System;
using System.Dynamic;
using System.Runtime.Versioning;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
//拡張メソッドを定義したクラス
static class ExtendBMImethod
{
    //拡張メソッド(肥満度判定)
    public static void ChekJ(this BMImethod t)
    {
        //BMIが25以上を肥満、18未満を痩せすぎ、それ以外を標準とする
        if (25 <= t.BMI())
        {
            WriteLine("デブ");
        }
        else if (t.BMI() < 18)
        {
            WriteLine("ガリ");
        }
        else
        {
            WriteLine("普通");
        }
    }
}

//体重、身長を保持してBMI値を出力するクラス
class BMImethod 
{
    //体重
    public double Weight { get; }
    //身長
    public double Height { get; set; }
    //体重、身長を指定して初期化
    public BMImethod(double w, double h)
    {
        this.Weight = w;
        this.Height = h/100;
    }
    //BMI値を求める
    public double BMI()
    {
        return this.Weight / (this.Height * this.Height);
    }
}
class MainClass
{
    public static void Main()
    {
        //体重、身長を指定(kg,cm)
        BMImethod a = new BMImethod(80, 170);
        //肥満度の判定(拡張メソッド)
        a.ChekJ();

        var b = new BMImethod(40, 160);
        b.ChekJ();

        var c = new BMImethod(68, 171);
        c.ChekJ();

    }
}
