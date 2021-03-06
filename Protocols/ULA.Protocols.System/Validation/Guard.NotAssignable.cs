﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YP.Toolkit.System.Exceptions;

namespace YP.Toolkit.System.Validation
{
    /// <summary>
    /// Represents guardian for common used validation rules
    /// </summary>
    public static partial class Guard
    {
        /// <summary>
        /// Invokes ininassignability validation rule.
        /// If a type of value is not assignable to type of <see cref="TTypeToCheck"/> throwing ArgumentException.
        /// </summary>
        /// <typeparam name="TTypeToCheck">Type to check with</typeparam>
        /// <param name="checkableType">Checkable type</param>
        public static void AgainstIsNotAssignableFrom<TTypeToCheck>(Type checkableType)
        {
            Guard.AgainstIsNotAssignableFrom<TTypeToCheck>(checkableType, new ArgumentException());
        }

        /// <summary>
        /// Invokes ininassignability validation rule.
        /// If a type of value is not assignable from type of <see cref="TTypeToCheck"/> throwing a custom Exception.
        /// </summary>
        /// <typeparam name="TTypeToCheck">Type to check with</typeparam>
        /// <param name="checkableType">Checkable type</param>
        /// <param name="exception">A custom exception to throw</param>
        public static void AgainstIsNotAssignableFrom<TTypeToCheck>(Type checkableType, Exception exception)
        {
            Guard.AgainstNullReference(checkableType);
            bool result = checkableType.IsAssignableFrom(typeof(TTypeToCheck));
            if (!result) throw exception;
        }

        /// <summary>
        /// Invokes ininassignability validation rule.
        /// If a type of value is not assignable from type of <see cref="TTypeToCheck"/> throwing an ArgumentNullException.
        /// </summary>
        /// <typeparam name="TTypeToCheck">Type to check with</typeparam>
        /// <param name="checkableType">Checkable type</param>
        /// <param name="parameterName">A method parameter name</param>
        public static void AgainstIsNotAssignableFrom<TTypeToCheck>(Type checkableType,
            [InvokerParameterName] string parameterName)
        {
            Guard.AgainstIsNotAssignableFrom<TTypeToCheck>(checkableType, new ArgumentNullException(parameterName));
        }

        /// <summary>
        /// Invokes ininassignability validation rule.
        /// If a type of value is not assignable from type of <see cref="TTypeToCheck"/> throwing a <see cref="TException"/>.
        /// </summary>
        /// <typeparam name="TTypeToCheck">Type to check with</typeparam>
        /// <typeparam name="TException">Type of exception</typeparam>
        /// <param name="checkableType">Checkable Type</param>
        public static void AgainstIsNotAssignableFrom<TTypeToCheck, TException>(Type checkableType)
            where TException : Exception, new()
        {
            Guard.AgainstNullReference(checkableType);
            bool result = checkableType.IsAssignableFrom(typeof(TTypeToCheck));
            if (!result) Guard.Throw<TException>();
        }

        /// <summary>
        /// Invokes ininassignability validation rule.
        /// If a type of value is not assignable from type of <see cref="TTypeToCheck"/> throwing a <see cref="TException"/> with exception message.
        /// </summary>
        /// <typeparam name="TTypeToCheck">Type to check with</typeparam>
        /// <typeparam name="TException">Type of exception</typeparam>
        /// <param name="checkableType">Checkable type</param>
        /// <param name="message">An exception message</param>
        public static void AgainstIsNotAssignableFrom<TTypeToCheck, TException>(Type checkableType, string message)
            where TException : ExceptionBase, new()
        {
            Guard.AgainstNullReference(checkableType);
            bool result = checkableType.IsAssignableFrom(typeof(TTypeToCheck));
            if (!result) Guard.Throw<TException>(message);
        }

        /// <summary>
        /// Invokes ininassignability validation rule.
        /// If a type of value is not assignable from type of <see cref="TTypeToCheck"/> throwing a <see cref="TException"/> and exception message.
        /// </summary>
        /// <typeparam name="TTypeToCheck">Type to check with</typeparam>
        /// <typeparam name="TException">Type of exception</typeparam>
        /// <param name="checkableType">Checkable type</param>
        /// <param name="parameterName">A method parameter name</param>
        /// <param name="message">An exception message</param>
        public static void AgainstIsNotAssignableFrom<TTypeToCheck, TException>(Type checkableType,
            [InvokerParameterName] string parameterName, string message)
            where TException : ExceptionBase, new()
        {
            Guard.AgainstNullReference(checkableType);
            bool result = checkableType.IsAssignableFrom(typeof(TTypeToCheck));
            if (!result) Guard.Throw<TException>(message, new ArgumentNullException(parameterName));
        }

        /// <summary>
        /// Invokes inassignability validation rule.
        /// If a type of first parameter is not assignable from type of second parameter of function throwing a custom exception.
        /// </summary>
        /// <param name="checkingType">Checkable type</param>
        /// <param name="typeToCheckFor">Type to check with</param>
        public static void AgainstIsNotAssignableFrom(Type checkingType, Type typeToCheckFor)
        {
            Guard.AgainstIsNotAssignableFrom(checkingType, typeToCheckFor, new ArgumentException());
        }

        /// <summary>
        /// Invokes inassignability validation rule.
        /// If a type of first parameter is not assignable from type of second parameter of function throwing a custom exception.
        /// </summary>
        /// <param name="checkingType">Chaeckable type</param>
        /// <param name="typeToCheckFor">Type to check with</param>
        /// <param name="exception">A custom exception to throw</param>
        public static void AgainstIsNotAssignableFrom(Type checkingType, Type typeToCheckFor, Exception exception)
        {
            Guard.AgainstNullReference(checkingType);
            Guard.AgainstNullReference(typeToCheckFor);
            bool result = checkingType.IsAssignableFrom(typeToCheckFor);
            if (!result) throw exception;
        }

        /// <summary>
        /// Invokes inassignability validation rule.
        /// If a type of first parameter is not assignable from type of second parameter of function throwing an ArgumentNullException.
        /// </summary>
        /// <param name="checkingType">Checkable type</param>
        /// <param name="typeToCheckFor">Type to check with</param>
        /// <param name="parameterName">A method parameter name</param>
        public static void AgainstIsNotAssignableFrom(Type checkingType, Type typeToCheckFor,
            [InvokerParameterName] string parameterName)
        {
            Guard.AgainstIsNotAssignableFrom(checkingType, typeToCheckFor, new ArgumentNullException(parameterName));
        }

        /// <summary>
        /// Invokes inassignability validation rule.
        /// If a type of first parameter is not assignable from type of second parameter of function throwing a <see cref="TException"/>. 
        /// </summary>
        /// <typeparam name="TException">Type of exception to throw</typeparam>
        /// <param name="checkingType">Checkable type</param>
        /// <param name="typeToCheckFor">Type to check with</param>
        public static void AgainstIsNotAssignableFrom<TException>(Type checkingType, Type typeToCheckFor)
            where TException : Exception, new()
        {
            Guard.AgainstNullReference(checkingType);
            Guard.AgainstNullReference(typeToCheckFor);
            bool result = checkingType.IsAssignableFrom(typeToCheckFor);
            if (!result) Guard.Throw<TException>();
        }

        /// <summary>
        /// Invokes inassignability validation rule.
        /// If a type of first parameter is not assignable from type of second parameter of function throwing a <see cref="TException"/> with exception message. 
        /// </summary>
        /// <typeparam name="TException">Type of exception to throw</typeparam>
        /// <param name="checkingType">Checkable type</param>
        /// <param name="typeToCheckFor">Type to check with</param>
        /// <param name="message">An exception message</param>
        public static void AgainstIsNotAssignableFrom<TException>(Type checkingType, Type typeToCheckFor, string message)
            where TException : ExceptionBase, new()
        {
            Guard.AgainstNullReference(checkingType);
            Guard.AgainstNullReference(typeToCheckFor);
            bool result = checkingType.IsAssignableFrom(typeToCheckFor);
            if (!result) Guard.Throw<TException>(message);
        }

        /// <summary>
        /// Invokes inassignability validation rule.
        /// If a type of first parameter is not assignable from type of second parameter of function throwing a <see cref="TException"/> with exception message and with inner exception ArgumentNullException. 
        /// </summary>
        /// <typeparam name="TException">Type of exception to throw</typeparam>
        /// <param name="checkingType">Checkable type</param>
        /// <param name="typeToCheckFor">Type to check with</param>
        /// <param name="parameterName">A method parameter name</param>
        /// <param name="message">An exception message</param>
        public static void AgainstIsNotAssignableFrom<TException>(Type checkingType, Type typeToCheckFor,
            [InvokerParameterName] string parameterName, string message)
            where TException : ExceptionBase, new()
        {
            Guard.AgainstNullReference(checkingType);
            Guard.AgainstNullReference(typeToCheckFor);
            bool result = checkingType.IsAssignableFrom(typeToCheckFor);
            if (!result) Guard.Throw<TException>(message, new ArgumentNullException(parameterName));
        }
    }
}
