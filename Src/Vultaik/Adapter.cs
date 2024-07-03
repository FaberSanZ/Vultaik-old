// Copyright (c) Faber Leonardo. All Rights Reserved. https://github.com/FaberSanZ
// This code is licensed under the MIT license (MIT) (http://opensource.org/licenses/MIT)



using Vortice.Vulkan;
using static Vortice.Vulkan.Vulkan;

namespace Vultaik;

public unsafe class Adapter
{
    internal VkInstance Instance;
    internal VkPhysicalDevice gpu;

    public Adapter()
    {
        CreateInstance();
    }

    private void CreateInstance()
    {
        VkApplicationInfo appInfo = new()
        {
            pNext = null,
            applicationVersion = new VkVersion(0, 0, 1),
            engineVersion = new VkVersion(0, 0, 1),
        };

        VkInstanceCreateInfo vkInfo = new()
        {
            pNext = null,
            flags = VkInstanceCreateFlags.None,
            pApplicationInfo = &appInfo,

        };
    }
}

