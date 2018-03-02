pipeline {
  agent {
    node {
      label 'NET'
    }
    
  }
  stages {
	stage('Init') {
		steps {
			echo "Running ${env.BUILD_ID} on ${env.JENKINS_URL}!"
		}
	}
  
    stage('Checkout') {
      steps {
        echo "Check out from Git repository ..."
		git(url: 'https://github.com/zengyulu/WPF-Samples', branch: '#refs/heads/master')
      }
    }
  }
  environment {
    NUGET_FULLPATH = 'C:\\nuget\\nuget.exe'
  }
}