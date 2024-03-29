﻿using System;

namespace ConsulDemoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var consul = new Consul.ConsulClient(c =>
          {
              c.Address = new Uri("http://118.89.39.14:8500");
          }))
            {
                //取在Consul注册的全部服务
                var services = consul.Agent.Services().Result.Response;
                foreach (var s in services.Values)
                {
                    Console.WriteLine($"ID={s.ID},Service={s.Service},Addr={s.Address},Port={s.Port}");
                }
            }

            Console.ReadKey();
        }
    }
} 
