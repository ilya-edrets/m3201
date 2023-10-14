using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public class Tests
{
    private readonly ComputerComponentsFactory _computerComponentsFactory;

    public Tests()
    {
        var cpuList = new List<Cpu>();

        cpuList.Add(new Cpu { Name = "Intel i7 13600h" });
        cpuList.Add(new Cpu { Name = "Intel i3 13100h" });
        cpuList.Add(new Cpu { Name = "Intel i9 14900h" });
        var cpuFactory = new CpuFactory(cpuList);
        _computerComponentsFactory = new ComputerComponentsFactory(cpuFactory, null, null);
    }

    public void Test()
    {
        // act
        _computerComponentsFactory.CreateCpuByName("name");
    }
}