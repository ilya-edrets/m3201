using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class CpuFactory : IFactory<Cpu>
{
    private ICollection<Cpu> _cpuList;

    // public CpuFactory()
    // {
    //     _cpuList = new List<Cpu>();
    //
    //     _cpuList.Add(new Cpu { Name = "Intel i7 13600h" });
    //     _cpuList.Add(new Cpu { Name = "Intel i3 13100h" });
    //     _cpuList.Add(new Cpu { Name = "Intel i9 14900h" });
    // }

    public CpuFactory(ICollection<Cpu> cpuList)
    {
        _cpuList = cpuList;
    }

    public Cpu? CreateByName(string name)
    {
        return _cpuList
            .FirstOrDefault(cpu => cpu.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            ?.Clone();
    }
}