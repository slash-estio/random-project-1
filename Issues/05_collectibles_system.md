# Issue #5: Implement Collectibles System

**Status:** Not Started  
**Priority:** Medium  
**Assignee:** Developer Team  
**Labels:** `feature`, `progression`, `gameplay`  
**Estimated Time:** 8-12 hours  

## Description
Create a comprehensive system for collectible items including power-ups, upgrades, resources, and score items. This system will enhance gameplay depth and provide progression mechanics for the space game.

## Dependencies
- **Issue #1:** Player Controller Enhancement (collision detection for pickup)
- **Issue #4:** Health & Damage System (health-related collectibles)
- **Issue #2:** Weapon System (ammo and weapon collectibles)

## Detailed Todo List

### Core Collectible Framework
- [ ] **Create base Collectible class**
  - Abstract collectible with common functionality
  - Pickup detection and collision handling
  - Visual and audio feedback integration
  - Automatic cleanup and recycling

- [ ] **Implement collection detection**
  - Trigger collision detection with player
  - Configurable pickup radius
  - Magnetic collection (items pulled toward player)
  - Collection validation and conditions

- [ ] **Create collectible spawning system**
  - Random spawn locations
  - Timed spawning intervals
  - Event-triggered spawning (enemy death, level events)
  - Spawn balancing and distribution

### Power-up Items
- [ ] **Speed Boost Power-up**
  - Temporary movement speed increase
  - Configurable duration and effect strength
  - Visual indicator during effect
  - Stacking or replacement behavior

- [ ] **Damage Boost Power-up**
  - Temporary weapon damage increase
  - Visual weapon enhancement effects
  - Duration-based or shot-count based
  - Compatibility with all weapon types

- [ ] **Shield Boost Power-up**
  - Instant shield restoration
  - Temporary shield overcharge
  - Enhanced shield regeneration rate
  - Shield capacity increases

- [ ] **Invincibility Power-up**
  - Temporary damage immunity
  - Visual invincibility effects
  - Short duration with clear indicators
  - Emergency escape capability

### Permanent Upgrades
- [ ] **Weapon Upgrades**
  - Damage increase modules
  - Fire rate enhancement chips
  - Accuracy improvement systems
  - Special effect additions (piercing, explosive)

- [ ] **Ship Upgrades**
  - Maximum health increases
  - Shield capacity upgrades
  - Movement speed enhancements
  - Armor strengthening modules

- [ ] **Utility Upgrades**
  - Extended pickup radius
  - Enhanced regeneration rates
  - Reduced ability cooldowns
  - Special movement abilities

### Resource Collection
- [ ] **Fuel/Energy Resources**
  - Fuel canisters for extended boost
  - Energy cells for weapon charging
  - Battery packs for shield systems
  - Emergency power reserves

- [ ] **Ammunition Supplies**
  - Laser energy cartridges
  - Missile/rocket ammunition
  - Plasma charge cells
  - Universal ammo packs

- [ ] **Crafting Materials**
  - Scrap metal for repairs
  - Rare elements for upgrades
  - Technology components
  - Alien artifacts

### Score and Currency Items
- [ ] **Score Crystals**
  - Different crystal values (small, medium, large)
  - Bonus multiplier crystals
  - Rare crystals with special effects
  - Chain collection bonuses

- [ ] **Currency Collection**
  - Credits for purchases
  - Premium currency for special items
  - Black market currency
  - Trade-specific currencies

### Collection Mechanics
- [ ] **Magnetic Collection System**
  - Items attracted to player when nearby
  - Configurable attraction radius
  - Attraction force and speed
  - Visual attraction effects

- [ ] **Auto-Collection Features**
  - Full-screen collection ability
  - Time-based auto-collection
  - Low-health emergency collection
  - End-level collection sweep

- [ ] **Collection Combos and Chains**
  - Rapid collection bonuses
  - Same-type collection chains
  - Perfect collection achievements
  - Combo multiplier systems

### Visual and Audio Integration
- [ ] **Collectible Visual Effects**
  - Glow and pulsing animations
  - Particle effects around items
  - Rarity-based visual distinctions
  - Collection explosion effects

- [ ] **Collection Audio Feedback**
  - Pickup sound effects
  - Rarity-based audio variations
  - Collection combo audio
  - Power-up activation sounds

- [ ] **UI Notifications**
  - Collectible notification pop-ups
  - Effect duration timers
  - Collection statistics display
  - Achievement notifications

### Advanced Features
- [ ] **Collectible Rarity System**
  - Common, uncommon, rare, legendary tiers
  - Rarity-based effects and values
  - Special rare item spawning
  - Rarity visual distinctions

- [ ] **Time-Limited Collectibles**
  - Seasonal or event-specific items
  - Disappearing items (limited pickup time)
  - Rush mode collectibles
  - Daily bonus items

- [ ] **Collectible Interactions**
  - Items that affect other items
  - Combination effects between collectibles
  - Collectible-triggered events
  - Environmental interactions

## Technical Requirements

### Code Architecture
```csharp
// Core collectible classes:
public abstract class Collectible : MonoBehaviour
public class PowerUp : Collectible
public class Upgrade : Collectible
public class Resource : Collectible
public class CollectibleSpawner : MonoBehaviour

// Collectible types:
public enum CollectibleType { PowerUp, Upgrade, Resource, Score }
public enum PowerUpType { Speed, Damage, Shield, Invincibility }
public enum Rarity { Common, Uncommon, Rare, Legendary }
```

### Effect System
```csharp
[System.Serializable]
public class CollectibleEffect
{
    public float duration;
    public float strength;
    public bool isPermanent;
    public bool stackable;
}
```

### Collection Events
```csharp
// Events for collectible integration:
public UnityEvent<CollectibleType> OnItemCollected;
public UnityEvent<PowerUpType> OnPowerUpActivated;
public UnityEvent<float> OnScoreCollected;
public UnityEvent<Upgrade> OnUpgradeObtained;
```

## Acceptance Criteria

### Core Functionality
- [x] Player can collect items by moving into them
- [x] Different collectible types have distinct effects and behaviors
- [x] Power-ups provide temporary benefits with clear feedback
- [x] Permanent upgrades persist between game sessions
- [x] Resource collection integrates with other game systems

### User Experience
- [x] Collection provides satisfying visual and audio feedback
- [x] Power-up effects are clearly communicated to player
- [x] Collection UI shows current effects and durations
- [x] Item spawning feels balanced and rewarding
- [x] Rare items feel special and valuable

### Technical Requirements
- [x] System maintains 60+ FPS with many collectibles on screen
- [x] Memory usage remains stable with collectible spawning/despawning
- [x] Collection detection is reliable and responsive
- [x] Effects integrate cleanly with other game systems
- [x] All collectible behaviors are configurable

### Integration Requirements
- [x] Works with weapon system for ammo and weapon upgrades
- [x] Integrates with health system for healing items
- [x] Compatible with UI system for effect displays
- [x] Supports audio system for collection feedback
- [x] Ready for save system integration for permanent upgrades

## Testing Checklist
- [ ] All collectible types can be picked up correctly
- [ ] Power-up effects apply and remove at correct times
- [ ] Permanent upgrades persist properly
- [ ] Collection detection works reliably at all movement speeds
- [ ] Multiple simultaneous effects work without conflicts
- [ ] Spawning system creates balanced distribution
- [ ] UI updates correctly for all collection events
- [ ] Audio and visual effects trigger appropriately
- [ ] Performance remains stable with maximum collectibles
- [ ] Edge cases (simultaneous collection) handled properly

## Configuration Options
- Collectible spawn rates and locations
- Power-up effect durations and strengths
- Pickup radius and magnetic force
- Rarity distribution percentages
- Collection combo requirements
- Auto-collection triggers

## Future Extensions
- Collectible crafting system
- Trading between players
- Collectible storage and inventory
- Special collectible events
- Dynamic collectible effects
- Collectible-based achievements

## Related Issues
- **Issue #1:** Player Controller Enhancement (collision detection)
- **Issue #2:** Weapon System (ammo and weapon collectibles)
- **Issue #4:** Health & Damage System (healing items)
- **Issue #6:** UI System (collection notifications and effects display)
- **Issue #7:** Audio System (collection sound effects)
- **Issue #8:** Game State Management (permanent upgrade persistence)
- **Issue #9:** Visual Effects System (collection and power-up effects)