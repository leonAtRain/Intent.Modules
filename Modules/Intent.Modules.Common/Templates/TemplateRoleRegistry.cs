﻿using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Templates;

namespace Intent.Modules.Common.Templates
{
    internal static class TemplateRoleRegistry
    {
        private static readonly IDictionary<string, IList<ITemplate>> _templatesByRole = new Dictionary<string, IList<ITemplate>>();
        private static readonly IDictionary<(string Role, string ModelId), IList<ITemplate>> _templatesByRoleAndModelId = new Dictionary<(string Role, string ModelId), IList<ITemplate>>();
        private static readonly IDictionary<(string Role, object Model), IList<ITemplate>> _templatesByRoleAndModel = new Dictionary<(string Role, object Model), IList<ITemplate>>();

        public static void Register(string role, ITemplate templateInstance)
        {
            {
                if (!_templatesByRole.TryGetValue(role, out var templateInstances))
                {
                    _templatesByRole.Add(role, templateInstances = new List<ITemplate>());
                }
                templateInstances.Add(templateInstance);
            }
            {
                if (templateInstance is ITemplateWithModel templateWithModel &&
                    templateWithModel.Model is IMetadataModel metadataModel &&
                    metadataModel.Id != null)
                {
                    var key = (role, metadataModel.Id);
                    if (!_templatesByRoleAndModelId.TryGetValue(key, out var templateInstances))
                    {
                        _templatesByRoleAndModelId.Add(key, templateInstances = new List<ITemplate>());
                    }

                    templateInstances.Add(templateInstance);
                }
            }
            {
                if (templateInstance is ITemplateWithModel templateWithModel &&
                    templateWithModel.Model != null)
                {
                    var key = (role, templateWithModel.Model);
                    if (!_templatesByRoleAndModel.TryGetValue(key, out var templateInstances))
                    {
                        _templatesByRoleAndModel.Add(key, templateInstances = new List<ITemplate>());
                    }

                    templateInstances.Add(templateInstance);
                }
            }
        }

        /// <summary>
        /// Finds all templates with id of <paramref name="role"/>
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public static IEnumerable<ITemplate> FindTemplateInstancesForRole(string role)
        {
            if (_templatesByRole.TryGetValue(role, out var templates))
            {
                return templates;
            }

            return Array.Empty<ITemplate>();
        }

        /// <summary>
        /// Finds all templates with <see cref="ITemplate.Id"/> of <paramref name="role"/>
        /// which is also a <see cref="ITemplateWithModel"/> whose
        /// <see cref="ITemplateWithModel.Model"/> is a <see cref="IMetadataModel"/> whose
        /// <see cref="IMetadataModel.Id"/> matches the provided
        /// <paramref name="metadataModelId"/>.
        /// </summary>
        public static IEnumerable<ITemplate> FindTemplateInstancesForRole(string role, string metadataModelId)
        {
            if (_templatesByRoleAndModelId.TryGetValue((role, metadataModelId), out var templates))
            {
                return templates;
            }

            return Array.Empty<ITemplate>();
        }

        /// <summary>
        /// Finds all templates with <see cref="ITemplate.Id"/> of <paramref name="role"/>
        /// which is also a <see cref="ITemplateWithModel"/> whose
        /// <see cref="ITemplateWithModel.Model"/>'s reference matches that of the provided
        /// <paramref name="model"/>.
        /// </summary>
        public static IEnumerable<ITemplate> FindTemplateInstancesForRole(string role, object model)
        {
            if (model is IMetadataModel metadataModel)
            {
                return FindTemplateInstancesForRole(role, metadataModel.Id);
            }
            if (_templatesByRoleAndModel.TryGetValue((role, model), out var templates))
            {
                return templates;
            }

            return Array.Empty<ITemplate>();
        }

        /// <summary>
        /// Finds the template with id of <paramref name="role"/> and that meets the <paramref name="predicate"/> filter.
        /// If more than one template is found then an exception will be thrown.
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public static ITemplate FindTemplateInstanceForRole(string role)
        {
            var results = FindTemplateInstancesForRole(role);
            if (results.Count() > 1)
            {
                throw new Exception(@$"Multiple templates found for role [{role}]:
    {string.Join(@"
    ", results.Select(x => x.ToString()))}");
            }
            return results.SingleOrDefault();
        }

        /// <summary>
        /// Finds the template with <see cref="ITemplate.Id"/> of <paramref name="role"/>
        /// which is also a <see cref="ITemplateWithModel"/> whose
        /// <see cref="ITemplateWithModel.Model"/> is a <see cref="IMetadataModel"/> whose
        /// <see cref="IMetadataModel.Id"/> matches the provided
        /// <paramref name="metadataModelId"/>.
        /// </summary>
        public static ITemplate FindTemplateInstanceForRole(string role, string metadataModelId)
        {
            var results = FindTemplateInstancesForRole(role, metadataModelId);
            if (results.Count() > 1)
            {
                throw new Exception(@$"Multiple templates found for role [{role}]:
    {string.Join(@"
    ", results.Select(x => x.ToString()))}");
            }
            return results.SingleOrDefault();
        }

        /// <summary>
        /// Finds the template with <see cref="ITemplate.Id"/> of <paramref name="role"/>
        /// which is also a <see cref="ITemplateWithModel"/> whose
        /// <see cref="ITemplateWithModel.Model"/>'s reference matches that of the provided
        /// <paramref name="model"/>.
        /// </summary>
        public static ITemplate FindTemplateInstanceForRole(string role, object model)
        {
            var results = FindTemplateInstancesForRole(role, model);
            if (results.Count() > 1)
            {
                throw new Exception(@$"Multiple templates found for role [{role}]:
    {string.Join(@"
    ", results.Select(x => x.ToString()))}");
            }
            return results.SingleOrDefault();
        }
    }
}