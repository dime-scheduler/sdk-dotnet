module.exports = {
  docs: [
    {
      type: 'category',
      label: 'Docs',
      collapsible: false,
      items: [
        'introduction',
        'about',
        'glossary'
      ]
    }, {
      type: 'category',
      label: 'Quick start',
      collapsible: true,
      collapsed: false,
      items: ['installation', 'example']
    }, {
      type: 'category',
      label: 'Implementations',
      collapsible: true,
      collapsed: true,
      items: [
        'connect',
        'powerplatform'
      ],
    }
  ],
  cli: [
    'cli/overview',
    'cli/auth',
    {
      type: 'category',
      label: 'Commands',
      collapsible: true,
      collapsed: true,
      items: [
        'cli/actionuri',
        'cli/appointments',
        'cli/captions',
        'cli/containers',
        'cli/filters',
        'cli/indicators',
        'cli/jobs',
        'cli/messages',
        'cli/notifications',
        'cli/resources',
        'cli/tasks',
        'cli/users'
      ],
    }
  ],
  api: {
    'Principles': [,
      'api/overview',
      'api/endpoints',
      'api/authentication'
    ],
    'Import': [
      'api/import/api',
      'api/import/validation',
      'api/import/endpoints'
    ],
    'Other endpoints': [
      'api/resources/resources',
      'api/messages/messages',
      'api/users/users',
      'api/license/license'
    ]
  }
};
