using EduHub.Domain.Entities;
using EduHub.Domain.Enums;
using Xunit;

namespace EduHub.Ch01.Tests;

public class DomainRulesTests
{
    [Fact]
    public void Create_member_normalizes_data_and_activates_member()
    {
        var member = Member.Create("  An  ", "dh24001", "AN@DTHU.EDU.VN");
        Assert.Equal("An", member.FullName);
        Assert.Equal("DH24001", member.StudentCode);
        Assert.Equal("an@dthu.edu.vn", member.Email);
        Assert.True(member.IsActive);
    }

    [Fact]
    public void Club_rejects_duplicate_or_inactive_member()
    {
        var club = Club.Create("CLB AI", "Nghiên cứu AI");
        var member = Member.Create("An", "DH24001", "an@dthu.edu.vn");
        club.AddMember(member);
        Assert.Throws<InvalidOperationException>(() => club.AddMember(member));
        var inactive = Member.Create("Bình", "DH24002", "binh@dthu.edu.vn");
        inactive.Deactivate();
        Assert.Throws<InvalidOperationException>(() => club.AddMember(inactive));
        inactive.Activate();
        club.AddMember(inactive);
        club.SetCanCreateEvent(false);
        Assert.False(club.CanCreateEvent);
        club.SetCanCreateEvent(true);
        Assert.True(club.CanCreateEvent);
    }

    [Fact]
    public void Event_rejects_invalid_capacity_and_reschedules_only_to_future()
    {
        var club = Club.Create("CLB AI", "Nghiên cứu AI");
        Assert.Throws<ArgumentOutOfRangeException>(() => Event.Create(club.Id, "Workshop", DateTime.UtcNow.AddDays(2), 0));
        var @event = Event.Create(club.Id, "Workshop", DateTime.UtcNow.AddDays(2), 10);
        Assert.Throws<ArgumentException>(() => @event.Reschedule(DateTime.UtcNow.AddMinutes(-1)));
        @event.Reschedule(DateTime.UtcNow.AddDays(3));
        Assert.True(@event.IsRescheduled);
    }

    [Fact]
    public void Registration_has_valid_lifecycle_and_24_hour_cancellation_rule()
    {
        var registration = Registration.Create(Guid.NewGuid(), Guid.NewGuid());
        registration.Confirm();
        Assert.Equal(RegistrationStatus.Confirmed, registration.Status);
        Assert.Throws<InvalidOperationException>(() => registration.Confirm());
        Assert.Throws<InvalidOperationException>(() => registration.Cancel(DateTime.UtcNow.AddDays(2), DateTime.UtcNow.AddDays(1)));
        registration.Cancel(DateTime.UtcNow.AddDays(3), DateTime.UtcNow);
        Assert.Equal(RegistrationStatus.Cancelled, registration.Status);
    }

    [Fact]
    public void Check_in_requires_confirmed_registration()
    {
        var pending = Registration.Create(Guid.NewGuid(), Guid.NewGuid());
        Assert.Throws<InvalidOperationException>(() => CheckIn.Create(pending));
        pending.Confirm();
        var checkIn = CheckIn.Create(pending, "QR_GATE_A");
        Assert.Equal(pending.Id, checkIn.RegistrationId);
        Assert.Equal("QR_GATE_A", checkIn.DeviceInfo);
    }
}
