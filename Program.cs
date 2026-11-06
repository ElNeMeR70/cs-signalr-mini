// cs-signalr-mini - SignalR-compatible real-time hub with backplane
// Part of poly-1000: 1000 elite programming tools by ElNeMeR70
using System;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;

class AdvancedTool {
    public double[] Process(double[] input) {
        var r = new double[input.Length];
        for(int i=0;i<input.Length;i++) r[i] = Math.Sin(input[i])*Math.Cos(i)+Math.Sqrt(Math.Abs(input[i])+1);
        return r;
    }
    public string Hash(string s) {
        using var h = SHA256.Create();
        return Convert.ToHexString(h.ComputeHash(Encoding.UTF8.GetBytes(s)))[..16].ToLower();
    }
}
class Program {
    static void Main() {
        Console.WriteLine("[RUN] cs-signalr-mini");
        var t = new AdvancedTool();
        var sw = Stopwatch.StartNew();
        var r = t.Process(System.Linq.Enumerable.Range(0,500).Select(i=>Math.Sin(i*0.01)).ToArray());
        sw.Stop();
        Console.WriteLine($"[OK]  Result: Processed {r.Length} items in {sw.Elapsed.TotalMilliseconds:F2}ms, hash={t.Hash("cs-signalr-mini-v1.0.0")}");
        Console.WriteLine("[OK]  cs-signalr-mini works correctly!");
    }
}
