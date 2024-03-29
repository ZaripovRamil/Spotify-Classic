﻿using Models.DTO.Light;
using Models.Entities;
using Models.Entities.Enums;

namespace Models.DTO.Full;

public class UserFull
{
    public UserFull(User user)
    {
        Id = user.Id;
        ProfilePicId = user.ProfilePicId;
        Name = user.Name;
        Playlists = user.Playlists.Select(p => new PlaylistLight(p)).ToList();
        History = user.UserTracks
            .OrderByDescending(ut => ut.ListenTime)
            .Select(ut => ut.Track)
            .Distinct()
            .Take(10)
            .Select(t => new TrackLight(t))
            .ToList();
        Subscription = user.Subscription == null ? null : new SubscriptionLight(user.Subscription);
        SubscriptionExpire = user.SubscriptionExpire;
        Role = user.Role;
        Email = user.Email;
    }

    public string Id { get; set; }
    public string ProfilePicId { get; set; }
    public string Name { get; set; }
    public Role Role { get; set; }
    public string? Email { get; set; }
    public DateTime? SubscriptionExpire { get; set; }
    public SubscriptionLight? Subscription { get; set; }
    public List<TrackLight> History { get; set; }
    public List<PlaylistLight> Playlists { get; set; }
}