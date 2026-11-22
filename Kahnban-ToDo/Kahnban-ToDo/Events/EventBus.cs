using System;
using System.Collections.Generic;
using System.Text;

namespace Kahnban_ToDo
{
    internal class EventBus
    {
        // Location memory
        private static List<EnumAction> actions = new();
        private static List<Action> pendingChanges = new();

        // State
        private static bool _isPublishing = false;

        public static void Publish(object sender, Enum eventEnum)
        {
            // Do not continue if there are no subscribers
            EnumAction? enumAction = actions.FirstOrDefault(ea => ea.EventEnum.Equals(eventEnum));
            if (enumAction == null) return;

            _isPublishing = true;

            foreach (Action action in enumAction.Actions)
            {
                action?.Invoke();
            }

            _isPublishing = false;

            foreach (Action change in pendingChanges)
            {
                change();
            }

            pendingChanges.Clear();
        }

        public static void Subscribe(Enum eventEnum, Action action)
        {
            ArgumentNullException.ThrowIfNull(eventEnum);

            if (_isPublishing)
            {
                pendingChanges.Add(() => AddSubscription(eventEnum, action));
                return;
            }

            AddSubscription(eventEnum, action);
        }

        private static void AddSubscription(Enum eventEnum, Action action)
        {
            EnumAction? enumAction = actions.FirstOrDefault(ea => ea.EventEnum.Equals(eventEnum));
            if (enumAction == null)
            {
                enumAction = new EnumAction
                {
                    EventEnum = eventEnum,
                    Actions = new List<Action>()
                };
                actions.Add(enumAction);
            }
            enumAction.Actions.Add(action);
        }

        public static void Unsubscribe(Enum eventEnum, Action action)
        {
            ArgumentNullException.ThrowIfNull(eventEnum);

            if (_isPublishing)
            {
                pendingChanges.Add(() => RemoveSubscription(eventEnum, action));
                return;
            }

            RemoveSubscription(eventEnum, action);
        }

        private static void RemoveSubscription(Enum eventEnum, Action action)
        {
            EnumAction? enumAction = actions.FirstOrDefault(ea => ea.EventEnum.Equals(eventEnum));
            if (enumAction != null)
            {
                enumAction.Actions.Remove(action);
            }
        }
    }
}
