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
        'cli',
        'connect',
        'powerplatform'
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
