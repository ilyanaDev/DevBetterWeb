﻿using DevBetterWeb.Core.Interfaces;
using Moq;
using DevBetterWeb.Core.Services;
using DevBetterWeb.Core.Entities;

namespace DevBetterWeb.Tests.Services.MemberSubscriptionCancellationServiceTests
{
  public class MemberSubscriptionCancellationServiceTest
  {
    internal readonly Mock<IUserRoleMembershipService> _userRoleMembershipService;
    internal readonly Mock<IEmailService> _emailService;
    internal readonly Mock<IUserLookupService> _userLookup;
    internal readonly Mock<IRepository<Member>> _memberRepository;
    internal readonly Mock<IMemberSubscriptionPeriodCalculationsService> _subscriptionPeriodCalculationsService;

    internal readonly IMemberCancellationService _memberCancellationService;

    public MemberSubscriptionCancellationServiceTest()
    {
      _userRoleMembershipService = new Mock<IUserRoleMembershipService>();
      _emailService = new Mock<IEmailService>();
      _userLookup = new Mock<IUserLookupService>();
      _memberRepository = new Mock<IRepository<Member>>();
      _subscriptionPeriodCalculationsService = new Mock<IMemberSubscriptionPeriodCalculationsService>();
      _memberCancellationService = new MemberSubscriptionCancellationService(_userRoleMembershipService.Object,
        _emailService.Object, _userLookup.Object, _memberRepository.Object, _subscriptionPeriodCalculationsService.Object);
    }
  }

}
