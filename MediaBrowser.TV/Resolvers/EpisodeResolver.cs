﻿using System.ComponentModel.Composition;
using MediaBrowser.Controller.Events;
using MediaBrowser.Controller.Resolvers;
using MediaBrowser.TV.Entities;

namespace MediaBrowser.TV.Resolvers
{
    [Export(typeof(IBaseItemResolver))]
    public class EpisodeResolver : BaseVideoResolver<Episode>
    {
        protected override Episode Resolve(ItemResolveEventArgs args)
        {
            // If the parent is a Season or Series, then this is an Episode if the VideoResolver returns something
            if (args.Parent is Season || args.Parent is Series)
            {
                return base.Resolve(args);
            }

            return null;
        }
    }
}
