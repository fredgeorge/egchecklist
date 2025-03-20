/*
 * Copyright (c) 2025 by Fred George
 * May be used freely except for training; license required for training.
 * @author Fred George  fredgeorge@acm.org
 */

using static Engine.Checklists.ItemStatus;

namespace Engine.Checklists;

// Understands a boolean question
public class TrueFalseItem {
    private bool? _value;
    public ItemStatus Status() {
        if (_value == null) return Unknown;
        return (bool)_value ? Happy : Sad;
    }

    public void Be(bool value) => _value = value;

    public void Reset() => _value = null;
}