pipeline {
  agent {
    node {
      label 'NET'
    }
    
  }
  stages {
    stage('Checkout') {
      steps {
        git(url: 'https://github.com/zengyulu/WPF-Samples', branch: '#refs/heads/master')
      }
    }
  }
  environment {
    NUGET_FULLPATH = 'C:\\nuget\\nuget.exe'
  }
}