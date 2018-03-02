pipeline {
  agent {
    node {
      label 'NET'
    }
    
  }
  stages {
	stage('Initial') {
		steps {
			echo "Running ${env.BUILD_ID} on ${env.JENKINS_URL}!"
		}
	}
  
    stage('Checkout Sln') {
      steps {
        echo "Check out from Git repository ..."
		git(url: 'https://github.com/zengyulu/WPF-Samples', branch: '#refs/heads/master')
      }
    }
	
	stage('Nuget Restore') {
		steps {
			echo "Nuget restore packages"
			bat '${NUGET_FULLPATH} restore ${WORKSPACE}\WPFSamples.sln'
		}
	}
  }
  environment {
    NUGET_FULLPATH = 'C:\\nuget\\nuget.exe'
  }
}